using System.Collections.Generic;
using System;

namespace Engine
{
    // App
    public abstract partial class App : Bootstrap
    {
        internal event Action<SDL_Event> OnEvent;
        internal event Action OnInitialize;
        internal event Action OnUpdate;
        internal event Action OnRender;
        internal event Action OnQuit;
        

        internal override void MainInitialize()
        {
            var fileSystem = new FileSystem(this);
            var window = new Window(this);
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

