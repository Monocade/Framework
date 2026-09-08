using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_Init(uint flags)
        {
            return iSDL_Init(flags);
        }

        public static bool SDL_InitSubSystem(uint flags)
        {
            return iSDL_InitSubSystem(flags);
        }

        public static void SDL_QuitSubSystem(uint flags)
        {
            iSDL_QuitSubSystem(flags);
        }

        public static uint SDL_WasInit(uint flags)
        {
            return iSDL_WasInit(flags);
        }

        public static void SDL_Quit()
        {
            iSDL_Quit();
        }

        public static bool SDL_IsMainThread()
        {
            return iSDL_IsMainThread();
        }

        public static bool SDL_RunOnMainThread(SDL_MainThreadCallback callback, IntPtr userdata, bool wait_complete)
        {
            return iSDL_RunOnMainThread(Marshal.GetFunctionPointerForDelegate(callback), userdata, wait_complete);
        }

        public static bool SDL_SetAppMetadata(string appname, string appversion, string appidentifier)
        {
            fixed (byte* ptr1 = SDL_StringToNative(appname))
            fixed (byte* ptr2 = SDL_StringToNative(appversion))
            fixed (byte* ptr3 = SDL_StringToNative(appidentifier))
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