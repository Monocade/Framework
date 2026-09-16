using System.Collections.Generic;
using System;

namespace Engine
{
    public abstract unsafe class Bootstrap
    {
        internal readonly Queue<SDL_Event> AppEvents = new Queue<SDL_Event>();
        
        internal readonly SDL_AppIterate_func AppIterateDelegate;
        internal readonly SDL_AppEvent_func AppEventDelegate;
        internal readonly SDL_AppInit_func AppInitDelegate;
        internal readonly SDL_AppQuit_func AppQuitDelegate;

        internal abstract void MainInitialize();
        internal abstract void MainUpdate();
        internal abstract void MainQuit();


        protected Bootstrap()
        {
            SDL_main_func AppMainDelegate = AppMain;
            AppIterateDelegate = AppIterate;
            AppEventDelegate = AppEvent;
            AppInitDelegate = AppInit;
            AppQuitDelegate = AppQuit;
            
            SDL_Init(SDL_InitFlags.SDL_INIT_EVERYTHING);
            {
                SDL_SetMainReady();
                {
                    SDL_RunApp(0, IntPtr.Zero, AppMainDelegate, IntPtr.Zero);
                }
            }
        }

        private int AppMain(int argc, byte** argv)
        {
            SDL_EnterAppMainCallbacks(argc, (IntPtr)argv, AppInitDelegate, AppIterateDelegate, AppEventDelegate, AppQuitDelegate);
            {
                return 0;
            }
        }

        private SDL_AppResult AppInit(IntPtr* state, int argc, byte** argv)
        {
            MainInitialize();
            {
                return SDL_AppResult.SDL_APP_CONTINUE;
            }
        }
        
        private SDL_AppResult AppEvent(IntPtr state, SDL_Event* e)
        {
            AppEvents.Enqueue(*e);
            {
                if (e->Type == SDL_EventType.SDL_EVENT_QUIT)
                {
                    return SDL_AppResult.SDL_APP_SUCCESS;
                }
                
                return SDL_AppResult.SDL_APP_CONTINUE;
            }
        }
        
        private SDL_AppResult AppIterate(IntPtr state)
        {
            MainUpdate();
            {
                return SDL_AppResult.SDL_APP_CONTINUE;
            }
        }
        
        private void AppQuit(IntPtr state, SDL_AppResult result)
        {
            MainQuit();
            {
                SDL_Quit();
            }
        }
    }
}