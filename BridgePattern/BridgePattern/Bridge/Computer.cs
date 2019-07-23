using System;
using BridgePattern.Bridge.System;

namespace BridgePattern.Bridge
{
    public abstract class Computer
    {
        public abstract void Game();

        public abstract void Movie();

        public ISystem system { get; set; }
    }
}