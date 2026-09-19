using System;

namespace Engine
{
    // Platform Provider
    public abstract class PlatformProvider(App app)
    {
        protected readonly App App = app;
        
        public abstract SystemPlatform GetPlatform();

        public abstract bool IsDesktop();

        public abstract bool IsMobile();

        public abstract bool IsTablet();

        public abstract bool IsTV();
    }
}