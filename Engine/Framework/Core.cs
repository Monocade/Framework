using System;

namespace Engine
{
    public unsafe class Core
    {
        private bool IsRunning = true;
        
        public void Run()
        {
            SDL_Init(SDL_InitFlags.SDL_INIT_VIDEO);
            
            var window = SDL_CreateWindow("Hello", 800, 600, SDL_WindowFlags.SDL_WINDOW_HIGH_PIXEL_DENSITY);

            while (IsRunning)
            {
                while (SDL_PollEvent(out SDL_Event e))
                {
                    if (e.Type == SDL_EventType.SDL_EVENT_QUIT)
                    {
                        IsRunning = false;
                        return;
                    }
                }
            }
            
            SDL_DestroyWindow(window);
            SDL_Quit();
        }
    }
}

