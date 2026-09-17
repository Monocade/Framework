using System;

namespace Engine
{
    internal abstract class PlatformProvider
    {
        public abstract ExampleProvider Example { get; }
    }
}