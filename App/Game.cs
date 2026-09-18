using System;
using Engine;

namespace Application
{
    public class Game : App
    {
        public override void Initialize()
        {
            var saveDialogProvider = new SaveDialogProvider(this, Storage.BasePath);
            var fileDialogProvider = new FileDialogProvider(this, Storage.BasePath);
            var folderDialogProvider = new FileDialogProvider(this, Storage.BasePath);
            
            base.Initialize();
            {
                Dialog.Open(fileDialogProvider, Callback);
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