using System;
using GUISharp.Logging;
using SPB.Client;

namespace SPB
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
			AppLogger.Enabled = true;
			MainClient client = new();
			client.Start();
        }
    }
}