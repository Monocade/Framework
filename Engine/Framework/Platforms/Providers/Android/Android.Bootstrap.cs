using System;

namespace Engine
{
    public sealed class AndroidBootstrap : BootstrapProvider
    {
        public override void Run()
        {
            Console.WriteLine("Android platform");
        }
    }
}