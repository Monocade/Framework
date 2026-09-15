using System;
using System.Threading;
using Engine;

namespace Application
{
    public class Game : App
    {
        public override void Initialize()
        {
            base.Initialize();
            {
                var storage = Storage.Open(StorageType.User, "MyFile");
                
                Console.WriteLine(storage.IsReady);

                while (!storage.IsReady)
                {
                    Console.WriteLine("Waiting");
                    Thread.Sleep(100);
                }
                
                Console.WriteLine(storage.IsReady);
            }
        }

        public override void Update()
        {
            base.Update();
            {
                
            }
        }

        public override void Quit()
        {
            base.Quit();
            {
                Console.WriteLine("Game Quit");
            }
        }
    }
}