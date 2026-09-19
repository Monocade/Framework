using System.Threading.Tasks;
using System.Threading;
using System;

namespace Engine
{
    // Storage
    public sealed class Storage(App App, StorageProvider provider)
    {
        public string PrefPath(string app, string name) => provider.PrefPath(app, name);
        
        public string UserPath(UserFolder folder) => provider.UserPath(folder);

        public string Normalize(string path) => provider.Normalize(path);

        public string BasePath => provider.BasePath;
        
        
        
        public void OpenUserStorage(string app, string user, Action<StorageContainer> onReady, bool dispose = true)
        {
            Open(provider.OpenUserStorage(app, user), onReady, dispose);
        }
        
        public void OpenTitleStorage(string path, Action<StorageContainer> onReady, bool dispose = true)
        {
            Open(provider.OpenTitleStorage(path), onReady, dispose);
        }

        public void OpenFileStorage(string path, Action<StorageContainer> onReady, bool dispose = true)
        {
            Open(provider.OpenFileStorage(path), onReady, dispose);
        }
        
        public void CloseStorage(StorageContainer container)
        {
            provider.CloseStorage(container);
        }
        
        private void Open(StorageContainer container, Action<StorageContainer> onReady, bool dispose)
        {
            void Callback()
            {
                try
                {
                    onReady(container);
                }
                finally
                {
                    if (dispose)
                    {
                        container.Dispose();
                    }
                }
            }

            if (container.IsReady)
            {
                Callback();
                return;
            }

            Task.Run(() =>
            {
                while (!container.IsReady)
                {
                    Thread.Sleep(100);
                }

                App.RunOnMainThread(Callback);
            });
        }
    }
}