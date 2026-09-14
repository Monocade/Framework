using System.Collections.Generic;
using System.Linq;
using System;

namespace Engine
{
    public abstract class Module
    {
        private readonly App App;
        
        protected Module(App App)
        {
            this.App = App;
            {
                App.OnInitialize += Initialize;
                App.OnUpdate += Update;
                App.OnRender += Render;
                App.OnEvent += Event;
                App.OnQuit += Quit;
            }
        }
        
        internal virtual void Event(SDL_Event e) { }
        
        internal virtual void Initialize() { }
        
        internal virtual void Update() { }
        
        internal virtual void Render() { }
        
        internal virtual void Quit()
        {
            App.OnInitialize -= Initialize;
            App.OnUpdate -= Update;
            App.OnRender -= Render;
            App.OnEvent -= Event;
            App.OnQuit -= Quit;
        }
    }
}