using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace HardwareMonitorWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!IsRunAsAdmin())
            {
                // Yönetici olarak yeniden başlat
                try
                {
                    var exeName = Process.GetCurrentProcess().MainModule.FileName;
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeName)
                    {
                        UseShellExecute = true,
                        Verb = "runas" // Yönetici olarak çalıştır
                    };
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uygulama yönetici olarak başlatılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return; // Yönetici olarak yeniden başlatıldıktan sonra eski süreç kapanacak
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static bool IsRunAsAdmin()
        {
            try
            {
                WindowsIdentity id = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(id);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }
    }
}