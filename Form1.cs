using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;

namespace HardwareMonitorWinForms
{
    public partial class Form1 : Form
    {
        private Computer computer;
        private SensorType? currentSensorTypeFilter = null; // null = tümü, Temperature veya Fan seçilebilir
        private readonly Dictionary<SensorType, string> sensorUnits = new Dictionary<SensorType, string>
        {
            { SensorType.Temperature, "°C" },
            { SensorType.Fan, "RPM" },
            { SensorType.Voltage, "V" },
            { SensorType.Load, "%" },
            { SensorType.Clock, "MHz" }
        };

        public Form1()
        {
            InitializeComponent();

            // ListView sütunları
            listViewSensors.Columns.Clear();
            listViewSensors.Columns.Add("Donanım", 200);
            listViewSensors.Columns.Add("Sensör Adı", 200);
            listViewSensors.Columns.Add("Sensör Tipi", 100);
            listViewSensors.Columns.Add("Değer", 80);
            listViewSensors.Columns.Add("Birim", 50);
            listViewSensors.View = View.Details;
            listViewSensors.FullRowSelect = true;
            listViewSensors.GridLines = true;

            // Donanım bilgisini aç
            computer = new Computer()
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsStorageEnabled = true,
                IsMotherboardEnabled = true,
                IsControllerEnabled = true,
                IsNetworkEnabled = true
            };

            try
            {
                computer.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Donanım bilgileri alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Timer ayarları
            timerUpdate.Interval = 2000;
            timerUpdate.Tick += TimerUpdate_Tick;

            // Menü item eventleri
            sıcaklıklarToolStripMenuItem.Click += (s, e) => { currentSensorTypeFilter = SensorType.Temperature; StartUpdating(); };
            fanHızlarıToolStripMenuItem.Click += (s, e) => { currentSensorTypeFilter = SensorType.Fan; StartUpdating(); };
            tümSensörlerToolStripMenuItem.Click += (s, e) => { currentSensorTypeFilter = null; StartUpdating(); };
        }

        /// <summary>
        /// Sensör verilerinin güncellenmesini başlatır.
        /// </summary>
        private void StartUpdating()
        {
            if (timerUpdate == null || listViewSensors == null)
                return;

            timerUpdate.Stop();
            listViewSensors.Items.Clear();
            timerUpdate.Start();
        }

        /// <summary>
        /// Timer tetiklendiğinde sensör verilerini günceller.
        /// </summary>
        private async void TimerUpdate_Tick(object sender, EventArgs e)
        {
            if (timerUpdate == null)
                return;

            timerUpdate.Stop();
            try
            {
                await System.Threading.Tasks.Task.Run(() => UpdateSensorData());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sensör verileri güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                timerUpdate.Start();
            }
        }

        /// <summary>
        /// Sensör verilerini günceller ve ListView'a ekler.
        /// </summary>
        private void UpdateSensorData()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateSensorData));
                return;
            }

            if (listViewSensors == null)
                return;

            listViewSensors.BeginUpdate();
            listViewSensors.Items.Clear();

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();

                AddHardwareSensorsToListView(hardware, currentSensorTypeFilter);

                if (hardware.SubHardware != null)
                {
                    foreach (var subHardware in hardware.SubHardware)
                    {
                        subHardware.Update();
                        AddHardwareSensorsToListView(subHardware, currentSensorTypeFilter);
                    }
                }
            }

            listViewSensors.EndUpdate();
        }

        /// <summary>
        /// Donanımın sensörlerini ListView'a ekler.
        /// </summary>
        /// <param name="hardware">Donanım</param>
        /// <param name="filter">Sensör tipi filtresi (null ise tümü)</param>
        private void AddHardwareSensorsToListView(IHardware hardware, SensorType? filter)
        {
            foreach (var sensor in hardware.Sensors)
            {
                if (!sensor.Value.HasValue)
                    continue;

                if (filter.HasValue && sensor.SensorType != filter.Value)
                    continue;

                string valueStr = sensor.Value.Value.ToString("F1");
                string unit = sensorUnits.ContainsKey(sensor.SensorType) ? sensorUnits[sensor.SensorType] : "";

                ListViewItem item = new ListViewItem(hardware.Name);
                item.SubItems.Add(sensor.Name);
                item.SubItems.Add(sensor.SensorType.ToString());
                item.SubItems.Add(valueStr);
                item.SubItems.Add(unit);

                listViewSensors.Items.Add(item);
            }
        }

        /// <summary>
        /// Form kapanırken kaynakları serbest bırakır.
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                timerUpdate?.Stop();
                computer?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program kapanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}