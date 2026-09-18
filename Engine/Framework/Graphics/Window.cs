using System;

namespace Engine
{
    // Constructor
    public sealed unsafe partial class Window(App App) : Module(App)
    {
        internal SDL_Window* Handle
        {
            get; private set;
        }

        internal override void Initialize()
        {
            base.Initialize();
            {
                var flags = SDL_WindowFlags.SDL_WINDOW_HIDDEN | SDL_WindowFlags.SDL_WINDOW_HIGH_PIXEL_DENSITY;
                {
                    Handle = SDL_CreateWindow("Framework", 600, 400, flags);
                }
            }
        }

        internal override void Event(SDL_Event e)
        {
            base.Event(e);
            {
                var action = e.Type switch
                {
                    SDL_EventType.SDL_EVENT_WINDOW_ENTER_FULLSCREEN => OnFullscreenEnter,
                    SDL_EventType.SDL_EVENT_WINDOW_LEAVE_FULLSCREEN => OnFullscreenExit,
                    SDL_EventType.SDL_EVENT_WINDOW_FOCUS_LOST => OnFocusLost,
                    SDL_EventType.SDL_EVENT_WINDOW_FOCUS_GAINED => OnFocusGain,
                    SDL_EventType.SDL_EVENT_WINDOW_MOUSE_ENTER => OnMouseEnter,
                    SDL_EventType.SDL_EVENT_WINDOW_MOUSE_LEAVE => OnMouseExit,
                    SDL_EventType.SDL_EVENT_WINDOW_MAXIMIZED => OnMaximize,
                    SDL_EventType.SDL_EVENT_WINDOW_MINIMIZED => OnMinimize,
                    SDL_EventType.SDL_EVENT_WINDOW_RESTORED => OnRestore,
                    SDL_EventType.SDL_EVENT_WINDOW_RESIZED => OnResize,
                    SDL_EventType.SDL_EVENT_WINDOW_MOVED => OnMoved,
                    SDL_EventType.SDL_EVENT_WINDOW_SHOWN => OnShow,
                    SDL_EventType.SDL_EVENT_WINDOW_HIDDEN => OnHide,
                    _ => null
                };

                action?.Invoke();
            }
        }

        internal override void Quit()
        {
            base.Quit();
            {
                if (Handle != null)
                {
                    SDL_DestroyWindow(Handle);
                }
            }
        }
    }

    // API
    public unsafe partial class Window
    {
        public Action OnFullscreenEnter;
        public Action OnFullscreenExit;
        public Action OnMouseEnter;
        public Action OnMouseExit;
        public Action OnFocusLost;
        public Action OnFocusGain;
        public Action OnMaximize;
        public Action OnMinimize;
        public Action OnRestore;
        public Action OnResize;
        public Action OnMoved;
        public Action OnShow;
        public Action OnHide;
        
        
        public string Title
        {
            set => SDL_SetWindowTitle(Handle, value);
            get
            {
                var name = SDL_GetWindowTitle(Handle);
                {
                    return name;
                }
            }
        }
        
        public int Width
        {
            set => SDL_SetWindowSize(Handle, value, Height);
            get
            {
                SDL_GetWindowSize(Handle, out var w, out _);
                {
                    return w;
                }
            }
        }
        
        public int Height
        {
            set => SDL_SetWindowSize(Handle, Width, value);
            get
            {
                SDL_GetWindowSize(Handle, out _, out var h);
                {
                    return h;
                }
            }
        }
        
        public Vector2 Size
        {
            set => SDL_SetWindowSize(Handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowSize(Handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public Vector2 MinSize
        {
            set => SDL_SetWindowMinimumSize(Handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowMinimumSize(Handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public Vector2 MaxSize
        {
            set => SDL_SetWindowMaximumSize(Handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowMaximumSize(Handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public Vector2 Position
        {
            set => SDL_SetWindowPosition(Handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowPosition(Handle, out var x, out var y);
                {
                    return new Vector2(x, y);
                }
            }
        }
        
        public Vector2 AspectRatio
        {
            set => SDL_SetWindowAspectRatio(Handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowAspectRatio(Handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public bool Fullscreen
        {
            set => SDL_SetWindowFullscreen(Handle, value);
            get
            {
                var flags = SDL_GetWindowFlags(Handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) != 0;
                }
            }
        }
        
        public bool Resizable
        {
            set => SDL_SetWindowResizable(Handle, value);
            get
            {
                var flags = SDL_GetWindowFlags(Handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_RESIZABLE) != 0;
                }
            }
        }
        
        public bool Focusable
        {
            set => SDL_SetWindowFocusable(Handle, value);
            get
            {
                var flags = SDL_GetWindowFlags(Handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_NOT_FOCUSABLE) == 0;
                }
            }
        }
        
        public bool Minimized
        {
            set
            {
                if (value)
                {
                    SDL_MinimizeWindow(Handle);
                }
                else
                {
                    SDL_RestoreWindow(Handle);
                }
            }
            get
            {
                var flags = SDL_GetWindowFlags(Handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_MINIMIZED) != 0;
                }
            }
        }
        
        public bool Maximized
        {
            set
            {
                if (value)
                {
                    SDL_MaximizeWindow(Handle);
                }
                else
                {
                    SDL_RestoreWindow(Handle);
                }
            }
            get
            {
                var flags = SDL_GetWindowFlags(Handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_MAXIMIZED) != 0;
                }
            }
        }
        
        public void Restore()
        {
            SDL_RestoreWindow(Handle);
        }
        
        public void Minimize()
        {
            SDL_MinimizeWindow(Handle);
        }
        
        public void Maximize()
        {
            SDL_MaximizeWindow(Handle);
        }
        
        public void Focus()
        {
            SDL_RaiseWindow(Handle);
        }
        
        public void Hide()
        {
            SDL_HideWindow(Handle);
        }

        public void Show()
        {
            SDL_ShowWindow(Handle);
        }
    }
}