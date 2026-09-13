using System;

namespace Engine
{
    public sealed class Windows : PlatformProvider
    {
        public override BootstrapProvider Bootstrap { get; } = new WindowsBootstrap();
        
        public override ExampleProvider Example { get; } = new WindowsExample();
    }
}