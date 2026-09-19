using System;

namespace Engine
{
    // Dialog Provider
    public abstract class DialogProvider(App app)
    {
        protected readonly App App = app;
        
        public abstract void OpenFoldersDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null);
        
        public abstract void OpenFolderDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null);
        
        public abstract void OpenFilesDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null);
        
        public abstract void OpenFileDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null);
        
        public abstract void OpenSaveDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null);
    }
}