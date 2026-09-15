using System;

namespace Engine
{
    // Constructor
    public sealed partial class Window : Module
    {
        internal Window(App app) : base(app)
        {
            // Constructor
        }
    }

    // Window
    public unsafe partial class Window
    {
        internal static SDL_Window* handle
        {
            get; private set;
        }
        
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


        internal override void Initialize()
        {
            base.Initialize();
            {
                var flags = SDL_WindowFlags.SDL_WINDOW_HIDDEN | SDL_WindowFlags.SDL_WINDOW_HIGH_PIXEL_DENSITY;
                {
                    handle = SDL_CreateWindow("Framework", 600, 400, flags);
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
                if (handle != null)
                {
                    SDL_DestroyWindow(handle);
                }
            }
        }
    }

    // API
    public unsafe partial class Window
    {
        public static string Title
        {
            set => SDL_SetWindowTitle(handle, value);
            get
            {
                var name = SDL_GetWindowTitle(handle);
                {
                    return name;
                }
            }
        }
        
        public static int Width
        {
            set => SDL_SetWindowSize(handle, value, Height);
            get
            {
                SDL_GetWindowSize(handle, out var w, out _);
                {
                    return w;
                }
            }
        }
        
        public static int Height
        {
            set => SDL_SetWindowSize(handle, Width, value);
            get
            {
                SDL_GetWindowSize(handle, out _, out var h);
                {
                    return h;
                }
            }
        }
        
        public static Vector2 Size
        {
            set => SDL_SetWindowSize(handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowSize(handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public static Vector2 MinSize
        {
            set => SDL_SetWindowMinimumSize(handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowMinimumSize(handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public static Vector2 MaxSize
        {
            set => SDL_SetWindowMaximumSize(handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowMaximumSize(handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public static Vector2 Position
        {
            set => SDL_SetWindowPosition(handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowPosition(handle, out var x, out var y);
                {
                    return new Vector2(x, y);
                }
            }
        }
        
        public static Vector2 AspectRatio
        {
            set => SDL_SetWindowAspectRatio(handle, (int)value.X, (int)value.Y);
            get
            {
                SDL_GetWindowAspectRatio(handle, out var w, out var h);
                {
                    return new Vector2(w, h);
                }
            }
        }
        
        public static bool Fullscreen
        {
            set => SDL_SetWindowFullscreen(handle, value);
            get
            {
                var flags = SDL_GetWindowFlags(handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) != 0;
                }
            }
        }
        
        public static bool Resizable
        {
            set => SDL_SetWindowResizable(handle, value);
            get
            {
                var flags = SDL_GetWindowFlags(handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_RESIZABLE) != 0;
                }
            }
        }
        
        public static bool Focusable
        {
            set => SDL_SetWindowFocusable(handle, value);
            get
            {
                var flags = SDL_GetWindowFlags(handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_NOT_FOCUSABLE) == 0;
                }
            }
        }
        
        public static bool Minimized
        {
            set
            {
                if (value)
                {
                    SDL_MinimizeWindow(handle);
                }
                else
                {
                    SDL_RestoreWindow(handle);
                }
            }
            get
            {
                var flags = SDL_GetWindowFlags(handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_MINIMIZED) != 0;
                }
            }
        }
        
        public static bool Maximized
        {
            set
            {
                if (value)
                {
                    SDL_MaximizeWindow(handle);
                }
                else
                {
                    SDL_RestoreWindow(handle);
                }
            }
            get
            {
                var flags = SDL_GetWindowFlags(handle);
                {
                    return (flags & SDL_WindowFlags.SDL_WINDOW_MAXIMIZED) != 0;
                }
            }
        }
        
        public static void Restore()
        {
            SDL_RestoreWindow(handle);
        }
        
        public static void Minimize()
        {
            SDL_MinimizeWindow(handle);
        }
        
        public static void Maximize()
        {
            SDL_MaximizeWindow(handle);
        }
        
        public static void Focus()
        {
            SDL_RaiseWindow(handle);
        }
        
        public static void Hide()
        {
            SDL_HideWindow(handle);
        }

        public static void Show()
        {
            SDL_ShowWindow(handle);
        }
    }
}