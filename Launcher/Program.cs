using System;
using System.Windows.Forms;

namespace PVSmartLauncher
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            string? serverFile = null;

            if (args.Length > 0)
                serverFile = args[0];

            Application.Run(new MainForm(serverFile));
        }
    }
}
