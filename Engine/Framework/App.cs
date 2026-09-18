using System.Collections.Concurrent;
using System.Collections.Generic;
using System;

namespace Engine
{
    // App
    public abstract partial class App : Bootstrap
    {
        private static readonly ConcurrentQueue<Action> MainThreadQueue = new();
        private static Storage Storage;
        private static Window Window;
        

        internal override void MainInitialize()
        {
            Storage = new Storage(this);
            Window = new Window(this);
            {
                Initialize();
                {
                    Window.Show();
                }
            }
        }

        internal override void MainUpdate()
        {
            while (MainThreadQueue.TryDequeue(out var action))
            {
                action();
            }
            
            while (AppEvents.TryDequeue(out var e))
            {
                OnEvent?.Invoke(e);
            }
            
            Update();
            Render();
        }

        internal override void MainQuit()
        {
            Quit();
        }
    }

    // Main
    public abstract partial class App
    {
        internal event Action<SDL_Event> OnEvent;
        internal event Action OnInitialize;
        internal event Action OnUpdate;
        internal event Action OnRender;
        internal event Action OnQuit;
        
        
        public virtual void Initialize()
        {
            OnInitialize?.Invoke();
        }
        
        public virtual void Update()
        {
            OnUpdate?.Invoke();
        }
        
        public virtual void Render()
        {
            OnRender?.Invoke();
        }
        
        public virtual void Quit()
        {
            OnQuit?.Invoke();
        }
    }

    // API
    public abstract partial class App
    {
        internal static void RunOnMainThread(Action action)
        {
            MainThreadQueue.Enqueue(action);
        }
    }
}

