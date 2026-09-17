using System;

namespace Engine
{
    internal sealed class Windows : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new WindowsExample();
    }
}