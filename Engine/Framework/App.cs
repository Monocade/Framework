using System.Collections.Generic;
using System;

namespace Engine
{
    public abstract unsafe class App : Bootstrap
    {
        private SDL_Window* window;

        
        internal override void Init()
        {
            window = SDL_CreateWindow("Title", 600, 400, SDL_WindowFlags.SDL_WINDOW_HIGH_PIXEL_DENSITY);
        }

        internal override void Main(Queue<SDL_Event> events)
        {
            while (events.TryDequeue(out var e))
            {
                if (e.Type == SDL_EventType.SDL_EVENT_QUIT)
                {
                    SDL_Quit();
                }
            }
            
            Console.WriteLine("Main");
        }

        internal override void Quit()
        {
            Console.WriteLine("Exit");
        }
    }
}

