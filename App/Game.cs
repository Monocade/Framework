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
                FileSystem.OpenFilesDialog(DialogCallbackMultiple, FileSystem.BasePath);
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