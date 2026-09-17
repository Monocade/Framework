using System;

namespace Engine
{
    internal sealed class Android : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new AndroidExample();
    }
}