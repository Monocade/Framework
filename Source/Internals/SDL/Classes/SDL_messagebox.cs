using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_ShowMessageBox(SDL_MessageBoxData* messageBoxData, out int buttonID)
        {
            fixed (int* ptr1 = &buttonID)
            {
                return iSDL_ShowMessageBox(messageBoxData, ptr1);
            }
        }

        public static bool SDL_ShowSimpleMessageBox(SDL_MessageBoxFlags flags, string title, string message, SDL_Window* window)
        {
            var titlePtr = Native.StringToNative(title, SDL_NativeProvider);
            var messagePtr = Native.StringToNative(message, SDL_NativeProvider);
            {
                var result = iSDL_ShowSimpleMessageBox((uint)flags, (byte*)titlePtr, (byte*)messagePtr, window);
                {
                    Native.Free(titlePtr, SDL_NativeProvider);
                    Native.Free(messagePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }
    }
}