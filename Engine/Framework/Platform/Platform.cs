using System;

namespace Engine
{
    // Platform
    public static class Platform
    {
        public static Platforms GetPlatform() => (Platforms)SDL_GetPlatform();
        
        public static PlatformProvider Provider { get; private set; }

        
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
}