using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_Init(SDL_InitFlags flags)
        {
            return iSDL_Init((uint)flags);
        }

        public static bool SDL_InitSubSystem(SDL_InitFlags flags)
        {
            return iSDL_InitSubSystem((uint)flags);
        }

        public static void SDL_QuitSubSystem(SDL_InitFlags flags)
        {
            iSDL_QuitSubSystem((uint)flags);
        }

        public static uint SDL_WasInit(SDL_InitFlags flags)
        {
            return iSDL_WasInit((uint)flags);
        }

        public static void SDL_Quit()
        {
            iSDL_Quit();
        }

        public static bool SDL_IsMainThread()
        {
            return iSDL_IsMainThread();
        }

        public static bool SDL_RunOnMainThread(SDL_MainThreadCallback callback, IntPtr userdata, bool waitComplete)
        {
            return iSDL_RunOnMainThread(Marshal.GetFunctionPointerForDelegate(callback), userdata, waitComplete);
        }

        public static bool SDL_SetAppMetadata(string appName, string appVersion, string appIdentifier)
        {
            var appNamePtr = Native.StringToNative(appName, SDL_NativeProvider);
            var appVersionPtr = Native.StringToNative(appVersion, SDL_NativeProvider);
            var appIdentifierPtr = Native.StringToNative(appIdentifier, SDL_NativeProvider);
            {
                var result = iSDL_SetAppMetadata((byte*)appNamePtr, (byte*)appVersionPtr, (byte*)appIdentifierPtr);
                {
                    Native.Free(appNamePtr, SDL_NativeProvider);
                    Native.Free(appVersionPtr, SDL_NativeProvider);
                    Native.Free(appIdentifierPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetAppMetadataProperty(string name, string value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            var valuePtr = Native.StringToNative(value, SDL_NativeProvider);
            {
                var result = iSDL_SetAppMetadataProperty((byte*)namePtr, (byte*)valuePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    Native.Free(valuePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string SDL_GetAppMetadataProperty(string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = Native.NativeToString((IntPtr)iSDL_GetAppMetadataProperty((byte*)namePtr));
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }
    }
}