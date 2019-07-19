using System;

namespace BridgePattern
{
    public class DellLinux : Dell
    {
        public override string System()
        {
            return "Linux";
        }

        public override string Version()
        {
            return "CentOS release 6.5";
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