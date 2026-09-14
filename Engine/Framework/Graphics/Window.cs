using System;

namespace Engine
{
    public sealed class Window : Module
    {
        internal Window(App app) : base(app)
        {
            // Window constructor
        }

        internal override void Initialize()
        {
            base.Initialize();
            {
                Console.WriteLine("Window Init");
            }
        }

        internal override void Quit()
        {
            base.Quit();
            {
                Console.WriteLine("Window Quit");
            }
        }
    }
}