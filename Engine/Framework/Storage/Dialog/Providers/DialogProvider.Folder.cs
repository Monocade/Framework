using System;

namespace Engine
{
    public sealed unsafe class FolderDialogProvider(App app, string path, bool multiple = true) : DialogProvider
    {
        private readonly struct Context
        {
            public readonly Dialog.DialogCallback Callback;
            
            public Context(Dialog.DialogCallback callback)
            {
                Callback = callback;
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
                }
            }
            
            var context = new Context(callback);
            {
                SDL_ShowOpenFolderDialog(Callback, Native.ObjectToNative(context), app.Window.Handle, path, multiple);
            }
        }
    }
}