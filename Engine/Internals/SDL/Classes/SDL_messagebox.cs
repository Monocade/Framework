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
            fixed (byte* ptr1 = SDL_StringToNative(title))
            fixed (byte* ptr2 = SDL_StringToNative(message))
            {
                return iSDL_ShowSimpleMessageBox((uint)flags, ptr1, ptr2, window);
            }
        }
    }
}