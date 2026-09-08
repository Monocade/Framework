using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetVersion()
        {
            return iSDL_GetVersion();
        }

        public static string SDL_GetRevision()
        {
            return SDL_NativeToString(iSDL_GetRevision());
        }
    }
}