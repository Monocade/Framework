using System;

namespace Engine
{
    // Platform
    public sealed partial class Platform(App App, PlatformProvider provider) : Module(App)
    {
        public SystemPlatform GetPlatform()
        {
            return provider.GetPlatform();
        }

        public bool IsDesktop()
        {
            return provider.IsDesktop();
        }

        public bool IsMobile()
        {
            return provider.IsMobile();
        }

        public bool IsTablet()
        {
            return provider.IsTablet();
        }

        public bool IsTV()
        {
            return provider.IsTV();
        }
    }
}