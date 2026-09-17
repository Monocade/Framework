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
                FileSystem.OpenFileDialog(FileSystem.BasePath, DialogCallbackMultiple, [new DialogFilter { Name = "Dlls", Pattern = "dll" }], false);
            }
        }

        private void DialogCallbackMultiple(DialogResult result, string[] contents)
        {
            Console.WriteLine(result);

            foreach (var file in contents)
            {
                Console.WriteLine(file);
            }
        }
    }
}