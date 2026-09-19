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
                Dialog.OpenFileDialog(Callback, null, "Dlls", "dll");
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