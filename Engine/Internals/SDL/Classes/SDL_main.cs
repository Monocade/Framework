using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_main(int argc, IntPtr argv)
        {
            return iSDL_main(argc, (byte**)argv);
        }

        public static void SDL_SetMainReady()
        {
            iSDL_SetMainReady();
        }

        public static int SDL_RunApp(int argc, IntPtr argv, SDL_main_func mainFunction, IntPtr reserved)
        {
            return iSDL_RunApp(argc, (byte**)argv, Marshal.GetFunctionPointerForDelegate(mainFunction), reserved);
        }

        public static int SDL_EnterAppMainCallbacks(int argc, IntPtr argv, SDL_AppInit_func appInit, SDL_AppInit_func appIterate, SDL_AppEvent_func appEvent, SDL_AppQuit_func appQuit)
        {
            return iSDL_EnterAppMainCallbacks
            (
                argc, 
                (byte**)argv, 
                Marshal.GetFunctionPointerForDelegate(appInit),
                Marshal.GetFunctionPointerForDelegate(appIterate), 
                Marshal.GetFunctionPointerForDelegate(appEvent), 
                Marshal.GetFunctionPointerForDelegate(appQuit)
            );
        }

        public static void SDL_GDKSuspendComplete()
        {
            iSDL_GDKSuspendComplete();
        }
    }
}