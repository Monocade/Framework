using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Locale*[] SDL_GetPreferredLocales(out int count)
        {
            return SDL_NativeToArray(iSDL_GetPreferredLocales(null), out count);
        }
    }
}