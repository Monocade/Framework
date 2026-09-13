using System;

namespace Engine
{
    public sealed class Android : PlatformProvider
    {
        public override BootstrapProvider Bootstrap { get; } = new AndroidBootstrap();
        
        public override ExampleProvider Example { get; } = new AndroidExample();
    }
}