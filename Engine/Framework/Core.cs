using System;
using Engine.SDL3;

namespace Engine
{
    public unsafe class Core
    {
        public void Run()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO | SDL.SDL_INIT_AUDIO);
            
            var devices = SDL.SDL_GetAudioPlaybackDevices(out int count);

            Console.WriteLine(count);
            foreach (var device in devices)
            {
                Console.WriteLine(device);
            }
        }
    }
}

