using System;

namespace Engine
{
    // Core
    public class Core
    {
        public bool IsRunning { get; private set; }
        
        
        public void Run()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                {
                    Platform.Provider.Bootstrap.Run();
                    Platform.Provider.Example.Run();
                }
            }
        }

        internal void Main()
        {
            Console.WriteLine("Main");
        }

        internal void Exit()
        {
            if (IsRunning)
            {
                IsRunning = false;
            }
        }
    }
}

