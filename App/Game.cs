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
                FileSystem.OpenFileDialog(FileSystem.BasePath, Callback, null, true);
            }
        }

        private void Callback(DialogResult result, string[] contents)
        {
            foreach (var file in contents)
            {
                Console.WriteLine(file);
            }
        }
    }
}