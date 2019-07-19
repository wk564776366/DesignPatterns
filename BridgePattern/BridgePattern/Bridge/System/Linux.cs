using System;

namespace BridgePattern.Bridge.System
{
    internal class Linux : ISystem
    {
        public string System()
        {
            return "Linux";
        }

        public string Version()
        {
            return "CentOS release 6.5";
        }
    }
}