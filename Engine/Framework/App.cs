using System.Collections.Generic;
using System;

namespace Engine
{
    // App
    public abstract partial class App : Bootstrap
    {
        private FileSystem FileSystem;
        private Window Window;

        internal override void MainInitialize()
        {
            FileSystem = new FileSystem(this);
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
}

