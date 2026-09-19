using System;

namespace Engine
{
    // SDL Dialog Provider
    public sealed unsafe class SDLDialogProvider(App app) : DialogProvider(app)
    {
        private readonly struct Context
        {
            public readonly Dialog.DialogCallback Callback;
            public readonly SDL_DialogFileFilter Filter;
            
            public Context(Dialog.DialogCallback callback, SDL_DialogFileFilter filter)
            {
                Callback = callback;
                Filter = filter;
            }
        }

        public override void OpenFoldersDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null)
        {
            var context = new Context(callback, CreateFilter(name, pattern));
            {
                SDL_ShowOpenFolderDialog(Callback, Native.ObjectToNative(context), App.Window.Handle, path, true);
            }
        }
        
        public override void OpenFolderDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null)
        {
            var context = new Context(callback, CreateFilter(name, pattern));
            {
                SDL_ShowOpenFolderDialog(Callback, Native.ObjectToNative(context), App.Window.Handle, path, false);
            }
        }

        public override void OpenFilesDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null)
        {
            var context = new Context(callback, CreateFilter(name, pattern));
            {
                SDL_ShowOpenFileDialog(Callback, Native.ObjectToNative(context), App.Window.Handle, [context.Filter], 1, path, true);
            }
        }
        
        public override void OpenFileDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null)
        {
            var context = new Context(callback, CreateFilter(name, pattern));
            {
                SDL_ShowOpenFileDialog(Callback, Native.ObjectToNative(context), App.Window.Handle, [context.Filter], 1, path, false);
            }
        }

        public override void OpenSaveDialog(Dialog.DialogCallback callback, string path, string name = null, string pattern = null)
        {
            var context = new Context(callback, CreateFilter(name, pattern));
            {
                SDL_ShowSaveFileDialog(Callback, Native.ObjectToNative(context), App.Window.Handle, [context.Filter], 1, path);
            }
        }
        
        private void Callback(IntPtr nativeContext, byte** nativeFiles, int nativeFilter)
        {
            var files = Native.NativeToStringArray((IntPtr)nativeFiles, out var count);
            {
                var context = Native.NativeToObject<Context>(nativeContext);
                {
                    var result = nativeFiles == null ? DialogResult.Failed : count == 0 ? DialogResult.Cancelled : DialogResult.Success;
                    {
                        context.Callback?.Invoke(result, files);
                    }
                }
                
                Native.Free((IntPtr)context.Filter.Name, SDL_NativeProvider);
                Native.Free((IntPtr)context.Filter.Pattern, SDL_NativeProvider);
            }
        }
        
        private SDL_DialogFileFilter CreateFilter(string name, string pattern)
        {
            return new SDL_DialogFileFilter
            {
                Name = (byte*)Native.StringToNative(name ?? "All files", SDL_NativeProvider),
                Pattern = (byte*)Native.StringToNative(pattern ?? "*", SDL_NativeProvider),
            };
        }
    }
}