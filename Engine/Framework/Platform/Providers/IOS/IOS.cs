using System;

namespace Engine
{
    public sealed class IOS : PlatformProvider
    {
        public override ExampleProvider Example { get; } = new IOSExample();
    }
}