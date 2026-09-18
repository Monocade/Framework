using System.Threading.Tasks;
using System.Threading;
using System;

namespace Engine
{
    // Storage
    public sealed partial class Storage : Module
    {
        public static string PrefPath(string app, string name) => SDL_GetPrefPath(app, name);

        public static string Normalize(string path) => path.Replace("\\", "/");
        
        public static string BasePath => SDL_GetBasePath();
        
        
        internal Storage(App App) : base(App)
        {
            // Constructor
        }
    }
    
    // Storage API
    public unsafe partial class Storage
    {
        public static void OpenUserStorage(string app, string user, Action<StorageProvider> onReady)
        {
            user = Normalize(user);
            app = Normalize(app);
            {
                OpenStorageHandler(new UserStorageProvider(SDL_OpenUserStorage(app, user, 0)), onReady);
            }
        }
        
        public static void OpenTitleStorage(string path, Action<StorageProvider> onReady)
        {
            path = Normalize(path);
            {
                OpenStorageHandler(new TitleStorageProvider(SDL_OpenTitleStorage(path, 0)), onReady);
            }
        }
        
        public static void OpenFileStorage(string path, Action<StorageProvider> onReady)
        {
            path = Normalize(path);
            {
                OpenStorageHandler(new FileStorageProvider(SDL_OpenFileStorage(path)), onReady);
            }
        }

        private static void OpenStorageHandler(StorageProvider storageProvider, Action<StorageProvider> onReady)
        {
            void Callback()
            {
                try
                {
                    onReady(storageProvider);
                }
                finally
                {
                    storageProvider.Dispose();
                }
            }

            if (storageProvider.IsReady)
            {
                Callback();
                return;
            }

            Task.Run(() =>
            {
                while (!storageProvider.IsReady)
                {
                    Thread.Sleep(100);
                }

                App.RunOnMainThread(Callback);
            });
        }

        public static void CloseStorage(StorageProvider storageProvider)
        {
            storageProvider?.Dispose();
        }
    }

    // Dialog API
    public unsafe partial class Storage
    {
        public delegate void DialogCallback(DialogResult result, string[] contents);
        
        
        public static void OpenFolderDialog(string path, DialogCallback callback, DialogFilter[] filters = null, bool multiple = false)
        {
            OpenDialogHandler(path, callback, filters, DialogMode.OpenFolder, multiple);
        }
        
        public static void OpenFileDialog(string path, DialogCallback callback, DialogFilter[] filters = null, bool multiple = false)
        {
            OpenDialogHandler(path, callback, filters, DialogMode.OpenFile, multiple);
        }
        
        public static void OpenSaveDialog(string path, DialogCallback callback, DialogFilter[] filters = null)
        {
            OpenDialogHandler(path, callback, filters, DialogMode.SaveFile, false);
        }
        
        private static void OpenDialogHandler(string path, DialogCallback callback, DialogFilter[] filters, DialogMode mode, bool multiple)
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
                    SDL_ShowOpenFileDialog(DialogCallbackHandler, nativeContext, Window.Handle, nativeFilters, nativeFilters.Length, path, multiple);
                    break;
                }
                case DialogMode.SaveFile:
                {
                    SDL_ShowSaveFileDialog(DialogCallbackHandler, nativeContext, Window.Handle, nativeFilters, nativeFilters.Length, path);
                    break;
                }
                case DialogMode.OpenFolder:
                {
                    SDL_ShowOpenFolderDialog(DialogCallbackHandler, nativeContext, Window.Handle, path, multiple);
                    break;
                }
            }
        }
        
        private static void DialogCallbackHandler(IntPtr nativeContext, byte** nativeFiles, int nativeFilter)
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