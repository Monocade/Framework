using System;

namespace Engine
{
    // Platform
    public sealed partial class Platform(App App) : Module(App)
    {
        public SystemPlatform GetPlatform()
        {
            return (SystemPlatform)SDL_GetPlatform();
        }

        public bool IsDesktop()
        {
            return !IsMobile() && !IsTablet() && !IsTV();
        }

        public bool IsMobile()
        {
            return SDL_IsPhone();
        }

        public bool IsTablet()
        {
            return SDL_IsTablet();
        }

        public bool IsTV()
        {
            return SDL_IsTV();
        }
    }
}