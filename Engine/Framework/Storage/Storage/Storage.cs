using System.Threading.Tasks;
using System.Threading;
using System;

namespace Engine
{
    // Storage API
    public sealed class Storage(App App) : Module(App)
    {
        public string PrefPath(string app, string name) => SDL_GetPrefPath(app, name);

        public string Normalize(string path) => path.Replace("\\", "/");

        public string BasePath => SDL_GetBasePath();
        
        
        public void Open(StorageProvider provider, Action<StorageProvider> action)
        {
            void Callback()
            {
                try
                {
                    action(provider);
                }
                finally
                {
                    provider.Dispose();
                }
            }

            if (provider.IsReady)
            {
                Callback();
                return;
            }

            Task.Run(() =>
            {
                while (!provider.IsReady)
                {
                    Thread.Sleep(100);
                }

                App.RunOnMainThread(Callback);
            });
        }

        public void Close(StorageProvider provider)
        {
            provider?.Dispose();
        }
    }
}