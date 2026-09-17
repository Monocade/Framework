using System;

namespace Engine
{
    internal sealed class IOS : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new IOSExample();
    }
}