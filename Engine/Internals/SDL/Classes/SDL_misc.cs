using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_OpenURL(string url)
        {
            fixed (byte* ptr1 = SDL_StringToNative(url))
            {
                return iSDL_OpenURL(ptr1);
            }
        }
    }
}