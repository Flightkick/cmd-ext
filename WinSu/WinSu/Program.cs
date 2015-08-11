using System.Diagnostics;

namespace WinSu
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd") {Verb = "runas"};
            Process p = Process.Start(info);
        }
    }
}