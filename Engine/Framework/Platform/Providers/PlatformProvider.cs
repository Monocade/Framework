using System;

namespace Engine
{
    public abstract class PlatformProvider
    {
        public abstract ExampleProvider Example { get; }
    }
}