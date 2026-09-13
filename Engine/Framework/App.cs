using System.Collections.Generic;
using System;

namespace Engine
{
    public abstract class App : Bootstrap
    {
        internal override void Init()
        {
            Console.WriteLine("Init");
        }

        internal override void Main(Queue<SDL_Event> events)
        {
            while (events.TryDequeue(out var e))
            {
                Console.WriteLine($"Event: {e.Type}");
            }
            
            Console.WriteLine("Main");
        }

        internal override void Quit()
        {
            Console.WriteLine("Quit");
        }
    }
}

