using System;

namespace Engine
{
    // App
    public abstract partial class App : Bootstrap
    {
        public Window Window { get; private set; }
        

        internal override void MainInitialize()
        {
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
            while (AppThreadQueue.TryDequeue(out var action))
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

    // API
    public abstract partial class App
    {
        internal event Action<SDL_Event> OnEvent;
        internal event Action OnInitialize;
        internal event Action OnUpdate;
        internal event Action OnRender;
        internal event Action OnQuit;
        
        
        public void RunOnMainThread(Action action)
        {
            AppThreadQueue.Enqueue(action);
        }
        
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
}

