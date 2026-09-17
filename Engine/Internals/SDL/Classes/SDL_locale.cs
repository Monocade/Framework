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
                var preferredLocalesPtr = iSDL_GetPreferredLocales(&size);
                {
                    var result = Native.NativeToArray(preferredLocalesPtr, size, out count);
                    {
                        Native.Free((IntPtr)preferredLocalesPtr, SDL_NativeProvider);
                        return result;
                    }
                }
            }
        }
    }
}