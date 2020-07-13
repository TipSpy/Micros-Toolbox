using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Micros_Toolbox.Classes
{
    class Commands
    {
        public static Task RunPowershell(string Command)
        {
            return Task.Run(() => {
                Process ps = new Process();

                // NOT WORKING BECAUSE FILE DOESN'T EXIST

                ps.StartInfo.FileName = System32Path() + @"WindowsPowerShell\v1.0\powershell.exe";
                //ps.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ps.StartInfo.Arguments = "-Command " + Command;
                ps.Start();
                ps.WaitForExit();
            });
        }

        public static string System32Path()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return @"C:\Windows\System32\";
                //return @"C:\Windows\Sysnative\";
            }
            else
            {
                return @"C:\Windows\System32\";
            }
        }
    }
}
