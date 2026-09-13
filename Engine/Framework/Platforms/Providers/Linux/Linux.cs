using System;

namespace Engine
{
    public sealed class Linux : PlatformProvider
    {
        public override BootstrapProvider Bootstrap { get; } = new LinuxBootstrap();
        
        public override ExampleProvider Example { get; } = new LinuxExample();
    }
}