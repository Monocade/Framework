using System;

namespace Engine
{
    public sealed class MacBootstrap : BootstrapProvider
    {
        public override void Run()
        {
            Console.WriteLine("Mac platform");
        }
    }
}