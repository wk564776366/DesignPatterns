using System;

namespace BridgePattern.Bridge.System
{
    internal class Window10 : ISystem
    {
        public string System()
        {
            return "Windows";
        }

        public string Version()
        {
            return "Win10";
        }
    }
}