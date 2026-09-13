using System;

namespace Engine
{
    public sealed class IOSBootstrap : BootstrapProvider
    {
        public override void Run()
        {
            Console.WriteLine("IOS platform");
        }
    }
}