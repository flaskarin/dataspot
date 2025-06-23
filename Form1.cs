using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace dataspot_autorun
{
    public partial class Form1 : Form
    {
        private readonly string appName = "dataspot_autorun";
        private readonly string exeName = "dataspot_autorun.exe";
        private readonly string targetDir;
        private readonly string urlConfigPath;

        public Form1()
        {
            InitializeComponent();
            targetDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                appName);
            urlConfigPath = Path.Combine(targetDir, "config.txt");
            if (File.Exists(urlConfigPath))
                txtUrl.Text = File.ReadAllText(urlConfigPath);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            string currentExe = Process.GetCurrentProcess().MainModule.FileName;
            string targetExe = Path.Combine(targetDir, exeName);

            try
            {
                Directory.CreateDirectory(targetDir);
                File.Copy(currentExe, targetExe, true);
                File.WriteAllText(urlConfigPath, txtUrl.Text.Trim());

                using (var key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key?.SetValue(appName, $"\"{targetExe}\" -silent");
                }

                lblStatus.Text = "✅ Instalacija uspješna.";

                Process.Start(new ProcessStartInfo
                {
                    FileName = targetExe,
                    Arguments = "-silent",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Greška: " + ex.Message;
            }
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                string targetExe = Path.Combine(targetDir, exeName);

                using (var key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key?.DeleteValue(appName, false);
                }

                if (File.Exists(targetExe)) File.Delete(targetExe);
                if (File.Exists(urlConfigPath)) File.Delete(urlConfigPath);
                if (Directory.Exists(targetDir)) Directory.Delete(targetDir, true); 

                lblStatus.Text = "✅ Deinstalacija uspješna.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Greška: " + ex.Message;
            }
        }
    }
}
