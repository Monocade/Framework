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

        public static int SDL_EnterAppMainCallbacks(int argc, IntPtr argv, SDL_AppInit_func appinit, SDL_AppInit_func appiter, SDL_AppEvent_func appevent, SDL_AppQuit_func appquit)
        {
            return iSDL_EnterAppMainCallbacks
            (
                argc, 
                (byte**)argv, 
                Marshal.GetFunctionPointerForDelegate(appinit),
                Marshal.GetFunctionPointerForDelegate(appiter), 
                Marshal.GetFunctionPointerForDelegate(appevent), 
                Marshal.GetFunctionPointerForDelegate(appquit)
            );
        }

        public static void SDL_GDKSuspendComplete()
        {
            iSDL_GDKSuspendComplete();
        }
    }
}