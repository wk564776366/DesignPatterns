using System;

namespace BridgePattern
{
    public class Dell : BaseInfo
    {
        public override string System()
        {
            return "Windows";
        }

        public override string Version()
        {
            return "Win10";
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