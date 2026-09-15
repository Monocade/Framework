using System;

namespace Engine
{
    public sealed class Mac : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new MacExample();
    }
}