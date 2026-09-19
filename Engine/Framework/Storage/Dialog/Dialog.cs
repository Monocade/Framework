using System;

namespace Engine
{
    // Dialog
    public sealed class Dialog(App App, DialogProvider provider) : Module(App)
    {
        public delegate void DialogCallback(DialogResult result, string[] selection);
        

        public void OpenFoldersDialog(DialogCallback callback, string path, string name = null, string pattern = null)
        {
            provider.OpenFoldersDialog(callback, path, name, pattern);
        }
        
        public void OpenFolderDialog(DialogCallback callback, string path, string name = null, string pattern = null)
        {
            provider.OpenFolderDialog(callback, path, name, pattern);
        }

        public void OpenFilesDialog(DialogCallback callback, string path, string name = null, string pattern = null)
        {
            provider.OpenFilesDialog(callback, path, name, pattern);
        }
        
        public void OpenFileDialog(DialogCallback callback, string path, string name = null, string pattern = null)
        {
            provider.OpenFileDialog(callback, path, name, pattern);
        }

        public void OpenSaveDialog(DialogCallback callback, string path, string name = null, string pattern = null)
        {
            provider.OpenSaveDialog(callback, path, name, pattern);
        }
    }
}