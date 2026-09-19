using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_PenDeviceType SDL_GetPenDeviceType(uint penID)
        {
            return iSDL_GetPenDeviceType(penID);
        }
    }
}