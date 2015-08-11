using System.Diagnostics;

namespace WinGksudo
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
            ProcessStartInfo info = new ProcessStartInfo(args[0]) {Verb = "runas"};
            if (arguments != null)
            {
                arguments = arguments.Substring(0, arguments.Length - 1);
                info.Arguments = arguments;
            }
            Process p = Process.Start(info);
        }
    }
}