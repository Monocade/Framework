using System;

namespace Engine
{
    public sealed class Linux : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new LinuxExample();
    }
}