using System;

namespace Engine
{
    public sealed class Mac : PlatformProvider
    {
        public override BootstrapProvider Bootstrap { get; } = new MacBootstrap();
        
        public override ExampleProvider Example { get; } = new MacExample();
    }
}