using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_OpenURL(string url)
        {
            var urlPtr = Native.StringToNative(url, SDL_NativeProvider);
            {
                var result = iSDL_OpenURL((byte*)urlPtr);
                {
                    Native.Free(urlPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }
    }
}