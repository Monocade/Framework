using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Platform SDL_GetPlatform()
        {
            var platform = Native.NativeToString((IntPtr)iSDL_GetPlatform()).ToUpper().Replace(" ", "");
            {
                return platform switch
                {
                    _ when platform.Contains("EMSCRIPTEN") => SDL_Platform.Web,
                    
                    _ when platform.Contains("WINDOWS") => SDL_Platform.Windows,
                    _ when platform.Contains("LINUX") => SDL_Platform.Linux,
                    _ when platform.Contains("MAC") => SDL_Platform.Mac,
                    
                    _ when platform.Contains("ANDROID") => SDL_Platform.Android,
                    _ when platform.Contains("IOS") => SDL_Platform.IOS,
                    
                    _ when platform.Contains("PLAYSTATION") => SDL_Platform.PlayStation,
                    _ when platform.Contains("NINTENDO") => SDL_Platform.Nintendo,
                    _ when platform.Contains("XBOX") => SDL_Platform.Xbox,

                    _ => SDL_Platform.Unknown
                };
            }
        }
    }
}