using System.Collections.Generic;
using System;

namespace Engine
{
    internal static unsafe class Bootstrap
    {
        private static readonly Queue<SDL_Event> Events = new Queue<SDL_Event>();
        private static readonly SDL_AppIterate_func AppIterate = Iterate;
        private static readonly SDL_AppEvent_func AppEvent = Event;
        private static readonly SDL_AppInit_func AppInit = Init;
        private static readonly SDL_AppQuit_func AppQuit = Quit;
        private static readonly SDL_main_func AppMain = Main;
        private static App App;
        
        
        internal static void Execute(App app)
        {
            App = app;
            {
                SDL_Init(SDL_InitFlags.SDL_INIT_EVERYTHING);
                {
                    SDL_SetMainReady();
                    {
                        SDL_RunApp(0, IntPtr.Zero, AppMain, IntPtr.Zero);
                    }
                }
            }
        }

        private static int Main(int argc, byte** argv)
        {
            SDL_EnterAppMainCallbacks(argc, (IntPtr)argv, AppInit, AppIterate, AppEvent, AppQuit);
            {
                return 0;
            }
        }

        private static SDL_AppResult Init(IntPtr* state, int argc, byte** argv)
        {
            App.Init();
            {
                return SDL_AppResult.SDL_APP_CONTINUE;
            }
        }

        private static SDL_AppResult Iterate(IntPtr state)
        {
            App.Main(Events);
            {
                if (!App.IsRunning)
                {
                    return SDL_AppResult.SDL_APP_SUCCESS;
                }
                
                return SDL_AppResult.SDL_APP_CONTINUE;
            }
        }
        
        private static SDL_AppResult Event(IntPtr state, SDL_Event* e)
        {
            Events.Enqueue(*e);
            {
                return SDL_AppResult.SDL_APP_CONTINUE;
            }
        }
        
        private static void Quit(IntPtr state, SDL_AppResult result)
        {
            App.Exit();
            {
                SDL_Quit();
            }
        }
    }
}