using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Locale*[] SDL_GetPreferredLocales(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetPreferredLocales(&size), size, out count);
            }
        }
    }
}