using System;
using System.Diagnostics;

namespace WinSudo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string arguments = null;
            for (int i = 1; i < args.Length; i++)
            {
                arguments += (args[i].Contains(" ") ? (@"""" + args[i] + @"""") : args[i]) + " ";
            }

            ProcessStartInfo info = new ProcessStartInfo(args[0])
            {
                Verb = "runas",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            if (arguments != null)
            {
                arguments = arguments.Substring(0, arguments.Length - 1);
                info.Arguments = arguments;
            }

            try
            {
                Process p = new Process() { StartInfo = info };
                p.Start();
                while (!p.StandardOutput.EndOfStream)
                {
                    string line = p.StandardOutput.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}