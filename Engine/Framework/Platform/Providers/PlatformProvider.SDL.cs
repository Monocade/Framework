using System;

namespace Engine
{
    // SDL Platform Provider
    public sealed class SDLPlatformProvider(App app) : PlatformProvider(app)
    {
        public override SystemPlatform GetPlatform()
        {
            var platform = SDL_GetPlatform().ToUpper().Replace(" ", "");
            {
                return platform switch
                {
                    _ when platform.Contains("EMSCRIPTEN") => SystemPlatform.Web,
                    
                    _ when platform.Contains("WINDOWS") => SystemPlatform.Windows,
                    _ when platform.Contains("LINUX") => SystemPlatform.Linux,
                    _ when platform.Contains("MAC") => SystemPlatform.Mac,
                    
                    _ when platform.Contains("ANDROID") => SystemPlatform.Android,
                    _ when platform.Contains("IOS") => SystemPlatform.IOS,
                    
                    _ when platform.Contains("PLAYSTATION") => SystemPlatform.PlayStation,
                    _ when platform.Contains("NINTENDO") => SystemPlatform.Nintendo,
                    _ when platform.Contains("XBOX") => SystemPlatform.Xbox,

                    _ => SystemPlatform.Unknown
                };
            }
        }

        public override bool IsDesktop()
        {
            return !IsMobile() && !IsTablet() && !IsTV();
        }

        public override bool IsMobile()
        {
            return SDL_IsPhone();
        }

        public override bool IsTablet()
        {
            return SDL_IsTablet();
        }

        public override bool IsTV()
        {
            return SDL_IsTV();
        }
    }
}