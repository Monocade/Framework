using System;

namespace Engine
{
    internal sealed class Linux : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new LinuxExample();
    }
}