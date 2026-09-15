using System;
using Engine;

namespace Application
{
    public class Game : App
    {
        public override void Initialize()
        {
            base.Initialize();
            {
                FileSystem.StorageAPI.StorageOpen()
            }
        }

        private void Callback(string file)
        {
            Console.WriteLine(file);
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
                
            }
        }
    }
}