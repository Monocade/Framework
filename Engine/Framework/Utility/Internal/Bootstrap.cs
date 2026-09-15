using System.Collections.Generic;
using System;

namespace Engine
{
    public abstract unsafe class Bootstrap
    {
        internal readonly Queue<SDL_Event> MainEvents = new Queue<SDL_Event>();
        
        internal abstract void MainInitialize();
        internal abstract void MainUpdate();
        internal abstract void MainQuit();


        protected Bootstrap()
        {
            SDL_Init(SDL_InitFlags.SDL_INIT_EVERYTHING);
            {
                SDL_SetMainReady();
                {
                    SDL_RunApp(0, IntPtr.Zero, AppMain, IntPtr.Zero);
                }
            }
        }

        private int AppMain(int argc, byte** argv)
        {
            SDL_EnterAppMainCallbacks(argc, (IntPtr)argv, AppInit, AppIterate, AppEvent, AppQuit);
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
            MainEvents.Enqueue(*e);
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