using System.Threading.Tasks;
using System.Threading;
using System;

namespace Engine
{
    // FileSystem
    public sealed partial class FileSystem(App App) : Module(App)
    {
        // TODO: Add filesystem specifics
    }
    
    // Storage API
    public unsafe partial class FileSystem
    {
        public string PrefPath(string app, string name) => SDL_GetPrefPath(app, name);

        public string Normalize(string path) => path.Replace("\\", "/");

        public string BasePath => SDL_GetBasePath();
        
        
        public void OpenUserStorage(string app, string user, Action<Storage> onReady)
        {
            user = Normalize(user);
            app = Normalize(app);
            {
                OpenStorageHandler(new UserStorage(SDL_OpenUserStorage(app, user, 0)), onReady);
            }
        }
        
        public void OpenTitleStorage(string path, Action<Storage> onReady)
        {
            path = Normalize(path);
            {
                OpenStorageHandler(new TitleStorage(SDL_OpenTitleStorage(path, 0)), onReady);
            }
        }
        
        public void OpenFileStorage(string path, Action<Storage> onReady)
        {
            path = Normalize(path);
            {
                OpenStorageHandler(new FileStorage(SDL_OpenFileStorage(path)), onReady);
            }
        }
        
        public void CloseStorage(Storage storage)
        {
            storage?.Dispose();
        }

        
        private void OpenStorageHandler(Storage storage, Action<Storage> onReady)
        {
            void Callback()
            {
                try
                {
                    onReady(storage);
                }
                finally
                {
                    storage.Dispose();
                }
            }

            if (storage.IsReady)
            {
                Callback();
                return;
            }

            Task.Run(() =>
            {
                while (!storage.IsReady)
                {
                    Thread.Sleep(100);
                }

                App.RunOnMainThread(Callback);
            });
        }
    }

    // Dialog API
    public unsafe partial class FileSystem
    {
        public delegate void DialogCallback(DialogResult result, string[] selection);
        
        
        public void OpenFolderDialog(string path, DialogCallback callback, DialogFilter[] filters = null, bool multiple = false)
        {
            OpenDialogHandler(path, callback, filters, DialogMode.OpenFolder, multiple);
        }
        
        public void OpenFileDialog(string path, DialogCallback callback, DialogFilter[] filters = null, bool multiple = false)
        {
            OpenDialogHandler(path, callback, filters, DialogMode.OpenFile, multiple);
        }
        
        public void OpenSaveDialog(string path, DialogCallback callback, DialogFilter[] filters = null)
        {
            OpenDialogHandler(path, callback, filters, DialogMode.SaveFile, false);
        }
        
        
        private void OpenDialogHandler(string path, DialogCallback callback, DialogFilter[] filters, DialogMode mode, bool multiple)
        {
            var nativeFilters = new SDL_DialogFileFilter[filters?.Length ?? 0];

            for (int i = 0; i < nativeFilters.Length; i++)
            {
                nativeFilters[i] = new SDL_DialogFileFilter()
                {
                    Name = (byte*)Native.StringToNative(filters?[i].Name, SDL_NativeProvider),
                    Pattern = (byte*)Native.StringToNative(filters?[i].Pattern, SDL_NativeProvider),
                };
            }

            var nativeContext = Native.ObjectToNative
            (
                new DialogContext
                (
                    path, callback, nativeFilters, mode
                )
            );
            
            switch (mode)
            {
                case DialogMode.OpenFile:
                {
                    SDL_ShowOpenFileDialog(DialogCallbackHandler, nativeContext, App.Window.Handle, nativeFilters, nativeFilters.Length, path, multiple);
                    break;
                }
                case DialogMode.SaveFile:
                {
                    SDL_ShowSaveFileDialog(DialogCallbackHandler, nativeContext, App.Window.Handle, nativeFilters, nativeFilters.Length, path);
                    break;
                }
                case DialogMode.OpenFolder:
                {
                    SDL_ShowOpenFolderDialog(DialogCallbackHandler, nativeContext, App.Window.Handle, path, multiple);
                    break;
                }
            }
        }
        
        private void DialogCallbackHandler(IntPtr nativeContext, byte** nativeFiles, int nativeFilter)
        {
            var files = Native.NativeToStringArray((IntPtr)nativeFiles, out var count);
            {
                var context = Native.NativeToObject<DialogContext>(nativeContext);
                {
                    var result = nativeFiles == null ? DialogResult.Failed : count == 0 ? DialogResult.Cancelled : DialogResult.Success;
                    {
                        context.Callback?.Invoke(result, files);
                    }
                }
                
                foreach (var filter in context.NativeFilters)
                {
                    Native.Free((IntPtr)filter.Name, SDL_NativeProvider);
                    Native.Free((IntPtr)filter.Pattern, SDL_NativeProvider);
                }
            }
        }
    }
}