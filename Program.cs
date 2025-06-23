using dataspot_autorun;
using System.Diagnostics;
using System.IO;
using System;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        string appName = "dataspot_autorun";
        string targetDir = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), appName);
        string targetExe = Path.Combine(targetDir, "dataspot_autorun.exe");
        string currentExe = Process.GetCurrentProcess().MainModule.FileName;

        if (Path.GetDirectoryName(currentExe).Equals(targetDir, StringComparison.OrdinalIgnoreCase))
        {
            string configPath = Path.Combine(targetDir, "config.txt");
            string url = "";     

            if (File.Exists(configPath))
            {
                string fileUrl = File.ReadAllText(configPath).Trim();
                if (!string.IsNullOrWhiteSpace(fileUrl))
                    url = fileUrl;
            }          

            try
            {               
                Process.Start(new ProcessStartInfo
                {
                    FileName = "microsoft-edge:" + url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom otvaranja URL-a: " + ex.Message);
            }
        }
        else
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
