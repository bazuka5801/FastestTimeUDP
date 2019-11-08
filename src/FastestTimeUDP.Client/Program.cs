using FastestTimeUDP.Client.Utils;
using SapphireEngine;

namespace FastestTimeUDP.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            NativeMethods.AllocConsole();
            Framework.Initialization<AppCore>();
        }
    }
}