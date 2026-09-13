using System.Collections.Generic;
using System;

namespace Engine
{
    // App
    public abstract unsafe class App
    {
        public bool IsRunning { get; private set; }
        
        private SDL_Window* window;
        
        
        protected App()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                {
                    Bootstrap.Execute(this);
                }
            }
        }

        internal void Init()
        {
            window = SDL_CreateWindow("Title", 600, 400, SDL_WindowFlags.SDL_WINDOW_HIGH_PIXEL_DENSITY);
        }

        internal void Main(Queue<SDL_Event> events)
        {
            while (events.TryDequeue(out var e))
            {
                if (e.Type == SDL_EventType.SDL_EVENT_QUIT)
                {
                    Exit();
                    {
                        return;
                    }
                }
            }
            
            // Update
        }

        internal void Exit()
        {
            if (IsRunning)
            {
                IsRunning = false;
                
                // Quit
            }
        }
    }
}

