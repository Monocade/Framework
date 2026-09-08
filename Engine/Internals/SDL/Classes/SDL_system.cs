using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_SetX11EventHook(SDL_X11EventHook callback, IntPtr userdata)
        {
            iSDL_SetX11EventHook(Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static bool SDL_IsPhone()
        {
            return iSDL_IsPhone();
        }

        public static bool SDL_IsTablet()
        {
            return iSDL_IsTablet();
        }

        public static bool SDL_IsTV()
        {
            return iSDL_IsTV();
        }

        public static SDL_FormFactor SDL_GetDeviceFormFactor()
        {
            return iSDL_GetDeviceFormFactor();
        }

        public static string SDL_GetDeviceFormFactorName(SDL_FormFactor form_factor)
        {
            return SDL_NativeToString(iSDL_GetDeviceFormFactorName(form_factor));
        }

        public static SDL_Sandbox SDL_GetSandbox()
        {
            return iSDL_GetSandbox();
        }

        public static void SDL_OnApplicationWillTerminate()
        {
            iSDL_OnApplicationWillTerminate();
        }

        public static void SDL_OnApplicationDidReceiveMemoryWarning()
        {
            iSDL_OnApplicationDidReceiveMemoryWarning();
        }

        public static void SDL_OnApplicationWillEnterBackground()
        {
            iSDL_OnApplicationWillEnterBackground();
        }

        public static void SDL_OnApplicationDidEnterBackground()
        {
            iSDL_OnApplicationDidEnterBackground();
        }

        public static void SDL_OnApplicationWillEnterForeground()
        {
            iSDL_OnApplicationWillEnterForeground();
        }

        public static void SDL_OnApplicationDidEnterForeground()
        {
            iSDL_OnApplicationDidEnterForeground();
        }
    }
}