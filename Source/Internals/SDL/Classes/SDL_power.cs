using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_PowerState SDL_GetPowerInfo(out int seconds, out int percent)
        {
            fixed(int* ptr1 = &seconds)
            fixed(int* ptr2 = &percent)
            {
                return iSDL_GetPowerInfo(ptr1, ptr2);
            }
        }
    }
}