using System;

namespace Engine
{
    public sealed class Android : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new AndroidExample();
    }
}