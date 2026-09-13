using System;

namespace Engine
{
    public sealed class LinuxBootstrap : BootstrapProvider
    {
        public override void Run()
        {
            Console.WriteLine("Linux platform");
        }
    }
}