using System;
using System.Text;
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
                var storage = Storage.Open(StorageType.User, "lloyd");

                var input = Encoding.UTF8.GetBytes("Hello from SDL!");
                Storage.FileWrite(storage, "MyFile.txt", input);

                var output = Storage.FileRead(storage, "MyFile.txt");
                Console.WriteLine(Encoding.UTF8.GetString(output));
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
                
            }
        }
    }
}