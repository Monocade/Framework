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
            fixed (byte* ptr1 = SDL_StringToNative(appName))
            fixed (byte* ptr2 = SDL_StringToNative(appVersion))
            fixed (byte* ptr3 = SDL_StringToNative(appIdentifier))
            {
                return iSDL_SetAppMetadata(ptr1, ptr2, ptr3);
            }
        }

        public static bool SDL_SetAppMetadataProperty(string name, string value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            fixed (byte* ptr2 = SDL_StringToNative(value))
            {
                return iSDL_SetAppMetadataProperty(ptr1, ptr2);
            }
        }

        public static string SDL_GetAppMetadataProperty(string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return SDL_NativeToString(iSDL_GetAppMetadataProperty(ptr1));
            }
        }
    }
}