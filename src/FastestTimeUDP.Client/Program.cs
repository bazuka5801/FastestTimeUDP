using FastestTimeUDP.Client.Utils;
using SapphireEngine;

namespace FastestTimeUDP.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NativeMethods.AllocConsole();
            Framework.Initialization<AppCore>();
        }
    }
}