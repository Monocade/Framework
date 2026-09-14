using System;
using Engine;

namespace Application
{
    public class Game : App
    {
        public override void Initialize()
        {
            base.Initialize();
            {
                Console.WriteLine("Game Init");
            }
        }

        public override void Quit()
        {
            base.Quit();
            {
                Console.WriteLine("Game Quit");
            }
        }
    }
}