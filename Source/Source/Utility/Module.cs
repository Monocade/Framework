using System;

namespace Engine
{
    public abstract class Module : IDisposable
    {
        protected App App
        {
            get;
        }
        
        protected Module(App App)
        {
            this.App = App;
            {
                App.OnInitialize += Initialize;
                App.OnUpdate += Update;
                App.OnRender += Render;
                App.OnEvent += Event;
                App.OnQuit += Quit;
                App.OnQuit += Dispose;
            }
        }

        internal virtual void Event(SDL_Event e)
        {
            // Module Events
        }

        internal virtual void Initialize()
        {
            // Module Initialize
        }

        internal virtual void Update()
        {
            // Module Update
        }

        internal virtual void Render()
        {
            // Module Render
        }

        internal virtual void Quit()
        {
            // Module Quit
        }
        
        public void Dispose()
        {
            App.OnInitialize -= Initialize;
            App.OnUpdate -= Update;
            App.OnRender -= Render;
            App.OnEvent -= Event;
            App.OnQuit -= Quit;
            App.OnQuit -= Dispose;
        }
    }
}