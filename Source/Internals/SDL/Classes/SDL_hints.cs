using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_SetHintWithPriority(string name, string value, SDL_HintPriority priority)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            var valuePtr = Native.StringToNative(value, SDL_NativeProvider);
            {
                var result = iSDL_SetHintWithPriority((byte*)namePtr, (byte*)valuePtr, priority);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    Native.Free(valuePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetHint(string name, string value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            var valuePtr = Native.StringToNative(value, SDL_NativeProvider);
            {
                var result = iSDL_SetHint((byte*)namePtr, (byte*)valuePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    Native.Free(valuePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_ResetHint(string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_ResetHint((byte*)namePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static void SDL_ResetHints()
        {
            iSDL_ResetHints();
        }

        public static string SDL_GetHint(string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = Native.NativeToString((IntPtr)iSDL_GetHint((byte*)namePtr));
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_GetHintBoolean(string name, bool defaultValue)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_GetHintBoolean((byte*)namePtr, defaultValue);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_AddHintCallback(string name, SDL_HintCallback callback, IntPtr userdata)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_AddHintCallback((byte*)namePtr, Marshal.GetFunctionPointerForDelegate(callback), userdata);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static void SDL_RemoveHintCallback(string name, SDL_HintCallback callback, IntPtr userdata)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                iSDL_RemoveHintCallback((byte*)namePtr, Marshal.GetFunctionPointerForDelegate(callback), userdata);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                }
            }
        }
    }
}