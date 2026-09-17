using System;

namespace Engine
{
    internal sealed class Mac : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new MacExample();
    }
}