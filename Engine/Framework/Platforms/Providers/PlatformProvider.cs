using System;

namespace Engine
{
    public abstract class PlatformProvider
    {
        public abstract BootstrapProvider Bootstrap { get; }
        public abstract ExampleProvider Example { get; }
    }
}