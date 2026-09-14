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
                Window.Title = "Hello";
            }
        }

        public override void Update()
        {
            base.Update();
            {
                
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