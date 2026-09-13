using System;

namespace Engine
{
    public sealed class WindowsBootstrap : BootstrapProvider
    {
        public override void Run()
        {
            Console.WriteLine("Windows platform");
        }
    }
}