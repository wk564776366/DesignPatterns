using System;

namespace BridgePattern
{
    public class MacBook : BaseInfo
    {
        public override string System()
        {
            return "MacOS";
        }

        public override string Version()
        {
            return "macOS 10.15 ";
        }

        public override void Game()
        {
            Console.WriteLine("Brand:{0}| OS:{1}-{2}", this.GetType(), System(), Version());
        }

        public override void Movie()
        {
            Console.WriteLine("Brand:{0}| OS:{1}-{2}", this.GetType(), System(), Version());
        }
    }
}