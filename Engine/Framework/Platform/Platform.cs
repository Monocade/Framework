using System;

namespace Engine
{
    // Platform
    public static partial class Platform
    {
        internal static PlatformProvider Provider { get; private set; }
        
        static Platform()
        {
            Provider = GetPlatform() switch
            {
                Platforms.Android => new Android(),
                Platforms.Windows => new Windows(),
                Platforms.Linux => new Linux(),
                Platforms.Mac => new Mac(),
                Platforms.IOS => new IOS(),

                _ => throw new Exception($"Unsupported platform: {GetPlatform()}")
            };
        }
    }

    // API
    public static partial class Platform
    {
        public static Platforms GetPlatform()
        {
            return (Platforms)SDL_GetPlatform();
        }

        public static bool IsDesktop()
        {
            return !IsMobile() && !IsMobile() && !IsTV();
        }

        public static bool IsMobile()
        {
            return SDL_IsPhone();
        }

        public static bool IsTablet()
        {
            return SDL_IsTablet();
        }

        public static bool IsTV()
        {
            return SDL_IsTV();
        }
    }
}