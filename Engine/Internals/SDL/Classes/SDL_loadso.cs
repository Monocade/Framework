using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_SharedObject* SDL_LoadObject(string sofile)
        {
            fixed (byte* ptr1 = SDL_StringToNative(sofile))
            {
                return iSDL_LoadObject(ptr1);
            }
        }

        public static IntPtr SDL_LoadFunction(SDL_SharedObject* handle, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_LoadFunction(handle, ptr1);
            }
        }

        public static void SDL_UnloadObject(SDL_SharedObject* handle)
        {
            iSDL_UnloadObject(handle);
        }
    }
}