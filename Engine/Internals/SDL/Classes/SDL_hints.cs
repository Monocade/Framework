using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_SetHintWithPriority(string name, string value, SDL_HintPriority priority)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            fixed (byte* ptr2 = SDL_StringToNative(value))
            {
                return iSDL_SetHintWithPriority(ptr1, ptr2, priority);
            }
        }

        public static bool SDL_SetHint(string name, string value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            fixed (byte* ptr2 = SDL_StringToNative(value))
            {
                return iSDL_SetHint(ptr1, ptr2);
            }
        }

        public static bool SDL_ResetHint(string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_ResetHint(ptr1);
            }
        }

        public static void SDL_ResetHints()
        {
            iSDL_ResetHints();
        }

        public static string SDL_GetHint(string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return SDL_NativeToString(iSDL_GetHint(ptr1));
            }
        }

        public static bool SDL_GetHintBoolean(string name, bool defaultValue)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetHintBoolean(ptr1, defaultValue);
            }
        }

        public static bool SDL_AddHintCallback(string name, SDL_HintCallback callback, IntPtr userdata)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_AddHintCallback(ptr1, Marshal.GetFunctionPointerForDelegate(callback), userdata);
            }
        }

        public static void SDL_RemoveHintCallback(string name, SDL_HintCallback callback, IntPtr userdata)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                iSDL_RemoveHintCallback(ptr1, Marshal.GetFunctionPointerForDelegate(callback), userdata);
            }
        }
    }
}