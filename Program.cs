using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

class Program
{
    static void Main()
    {
        string appName = "StartupLauncher";
        string url = "https://gohoneko.neocities.org/learn/kana";

        string targetFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            appName
        );
        string targetExePath = Path.Combine(targetFolder, $"{appName}.exe");
        string currentExePath = Process.GetCurrentProcess().MainModule.FileName;

        try
        {
            if (!currentExePath.Equals(targetExePath, StringComparison.OrdinalIgnoreCase))
            {
                Directory.CreateDirectory(targetFolder);
                if (!File.Exists(targetExePath))
                {
                    File.Copy(currentExePath, targetExePath);
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = targetExePath,
                    UseShellExecute = true
                });

                return; 
            }

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (key.GetValue(appName) == null)
                {
                    key.SetValue(appName, $"\"{targetExePath}\"");
                }
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
