using System;

namespace BridgePattern.Bridge
{
    public class Dell : Computer
    {
        public override void Game()
        {
            Console.WriteLine("Brand:{0}| OS:{1}-{2}", this.GetType(), system.System(), system.Version());
        }

        public override void Movie()
        {
            Console.WriteLine("Brand:{0}| OS:{1}-{2}", this.GetType(), system.System(), system.Version());
        }
    }
}