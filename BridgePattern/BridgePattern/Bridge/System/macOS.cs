using System;

namespace BridgePattern.Bridge.System
{
    internal class macOS : ISystem
    {
        public string System()
        {
            return "MacOS";
        }

        public string Version()
        {
            return "macOS 10.15 ";
        }
    }
}