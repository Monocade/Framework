using System;

namespace Engine
{
    // Window
    public sealed unsafe partial class Window(App app) : Module(app)
    {
        internal static SDL_Window* handle;


        internal override void Initialize()
        {
            base.Initialize();
            {
                handle = SDL_CreateWindow("Framework", 600, 400, SDL_WindowFlags.SDL_WINDOW_HIDDEN);
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
        
        public void Restore()
        {
            SDL_RestoreWindow(handle);
        }
        
        public void Minimize()
        {
            SDL_MinimizeWindow(handle);
        }
        
        public void Maximize()
        {
            SDL_MaximizeWindow(handle);
        }
        
        public void Focus()
        {
            SDL_RaiseWindow(handle);
        }
        
        public void Hide()
        {
            SDL_HideWindow(handle);
        }

        public void Show()
        {
            SDL_ShowWindow(handle);
        }
    }
}