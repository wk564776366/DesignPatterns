using System;
using BridgePattern.Bridge;
using BridgePattern.Bridge.System;

namespace BridgePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dell dell = new Dell();
            {
                dell.Game();
                dell.Movie();
                dell.Version();
                dell.System();
            }
            MacBook mac = new MacBook();
            {
                mac.Game();
                mac.Movie();
                mac.Version();
                mac.System();
            }

            Customize custom = new Customize();
            {
                custom.Game();
                custom.Movie();
                custom.Version();
                custom.System();
            }

            DellLinux dellLinux = new DellLinux();
            {
                dellLinux.Game();
                dellLinux.Movie();
                dellLinux.Version();
                dellLinux.System();
            }

            ISystem macOs = new macOS();
            ISystem window = new Window10();
            ISystem linux = new Linux();

            Computer Dell = new BridgePattern.Bridge.Dell();
            {
                Dell.system = linux;
                Dell.Movie();
                Dell.Game();
            }

            Computer Mac = new BridgePattern.Bridge.MacBook();
            {
                Mac.system = window;
                Mac.Movie();
                Mac.Game();
            }
            Console.ReadKey();
        }
    }
}