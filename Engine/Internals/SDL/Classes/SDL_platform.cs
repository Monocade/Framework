using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static string SDL_GetPlatform()
        {
            return SDL_NativeToString(iSDL_GetPlatform());
        }
    }
}