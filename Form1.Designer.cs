namespace HardwareMonitorWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıcaklıklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanHızlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümSensörlerToolStripMenuItem;
        private System.Windows.Forms.ListView listViewSensors;
        private System.Windows.Forms.Timer timerUpdate;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıcaklıklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanHızlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümSensörlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewSensors = new System.Windows.Forms.ListView();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verilerToolStripMenuItem
            // 
            this.verilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sıcaklıklarToolStripMenuItem,
            this.fanHızlarıToolStripMenuItem,
            this.tümSensörlerToolStripMenuItem});
            this.verilerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verilerToolStripMenuItem.Name = "verilerToolStripMenuItem";
            this.verilerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.verilerToolStripMenuItem.Text = "Veriler";
            // 
            // sıcaklıklarToolStripMenuItem
            // 
            this.sıcaklıklarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.sıcaklıklarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sıcaklıklarToolStripMenuItem.Name = "sıcaklıklarToolStripMenuItem";
            this.sıcaklıklarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sıcaklıklarToolStripMenuItem.Text = "Sıcaklıklar";
            // 
            // fanHızlarıToolStripMenuItem
            // 
            this.fanHızlarıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.fanHızlarıToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fanHızlarıToolStripMenuItem.Name = "fanHızlarıToolStripMenuItem";
            this.fanHızlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fanHızlarıToolStripMenuItem.Text = "Fan Hızları";
            // 
            // tümSensörlerToolStripMenuItem
            // 
            this.tümSensörlerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.tümSensörlerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tümSensörlerToolStripMenuItem.Name = "tümSensörlerToolStripMenuItem";
            this.tümSensörlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümSensörlerToolStripMenuItem.Text = "Tüm Sensörler";
            // 
            // listViewSensors
            // 
            this.listViewSensors.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.listViewSensors.ForeColor = System.Drawing.Color.White;
            this.listViewSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSensors.HideSelection = false;
            this.listViewSensors.Location = new System.Drawing.Point(0, 24);
            this.listViewSensors.Name = "listViewSensors";
            this.listViewSensors.Size = new System.Drawing.Size(800, 426);
            this.listViewSensors.TabIndex = 1;
            this.listViewSensors.UseCompatibleStateImageBehavior = false;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 2000;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewSensors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Donanım Sensör İzleyici";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}