using FastestTimeUDP.Common.Utils;
using SapphireEngine;

namespace FastestTimeUDP.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NativeMethods.AllocConsole();
            NativeMethods.HideConsole();
            Framework.Initialization<AppCore>();
        }
    }
}