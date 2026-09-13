using System;

namespace Engine
{
    public sealed class IOS : PlatformProvider
    {
        public override BootstrapProvider Bootstrap { get; } = new IOSBootstrap();
        
        public override ExampleProvider Example { get; } = new IOSExample();
    }
}