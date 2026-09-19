using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_SetError(string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                var result = iSDL_SetError((byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetErrorV(string fmt, string ap)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            var apPtr = Native.StringToNative(ap, SDL_NativeProvider);
            {
                var result = iSDL_SetErrorV((byte*)fmtPtr, (byte*)apPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                    Native.Free(apPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_OutOfMemory()
        {
            return iSDL_OutOfMemory();
        }

        public static string SDL_GetError()
        {
            return Native.NativeToString((IntPtr)iSDL_GetError());
        }

        public static bool SDL_ClearError()
        {
            return iSDL_ClearError();
        }
    }
}