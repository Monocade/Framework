using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_SetError(string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                return iSDL_SetError(ptr1);
            }
        }

        public static bool SDL_SetErrorV(string fmt, string ap)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            fixed (byte* ptr2 = SDL_StringToNative(ap))
            {
                return iSDL_SetErrorV(ptr1, ptr2);
            }
        }

        public static bool SDL_OutOfMemory()
        {
            return iSDL_OutOfMemory();
        }

        public static string SDL_GetError()
        {
            return SDL_NativeToString(iSDL_GetError());
        }

        public static bool SDL_ClearError()
        {
            return iSDL_ClearError();
        }
    }
}