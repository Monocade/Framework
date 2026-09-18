using System;

namespace Engine
{
    public sealed unsafe class SaveDialogProvider(App app, string path, string name = null, string extensions = null) : DialogProvider
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
        
        public override void Open(Dialog.DialogCallback callback)
        {
            void Callback(IntPtr nativeContext, byte** nativeFiles, int nativeFilter)
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
            
            var context = new Context
            (
                callback, new SDL_DialogFileFilter
                {
                    Name = (byte*)Native.StringToNative(name ?? "All files", SDL_NativeProvider),
                    Pattern = (byte*)Native.StringToNative(extensions ?? "*", SDL_NativeProvider),
                }
            );
            
            SDL_ShowSaveFileDialog(Callback, Native.ObjectToNative(context), app.Window.Handle, [context.Filter], 1, path);
        }
    }
}