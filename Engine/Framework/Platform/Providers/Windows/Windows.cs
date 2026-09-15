using System;

namespace Engine
{
    public sealed class Windows : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new WindowsExample();
    }
}