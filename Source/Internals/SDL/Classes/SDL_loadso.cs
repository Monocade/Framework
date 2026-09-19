using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_SharedObject* SDL_LoadObject(string soFile)
        {
            var soFilePtr = Native.StringToNative(soFile, SDL_NativeProvider);
            {
                var result = iSDL_LoadObject((byte*)soFilePtr);
                {
                    Native.Free(soFilePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static IntPtr SDL_LoadFunction(SDL_SharedObject* handle, string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_LoadFunction(handle, (byte*)namePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static void SDL_UnloadObject(SDL_SharedObject* handle)
        {
            iSDL_UnloadObject(handle);
        }
    }
}