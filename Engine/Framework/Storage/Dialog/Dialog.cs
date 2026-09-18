using System;

namespace Engine
{
    // Dialog API
    public sealed class Dialog(App App) : Module(App)
    {
        public delegate void DialogCallback(DialogResult result, string[] selection);
        
        public void Open(DialogProvider provider, DialogCallback callback)
        {
            provider.Open(callback);
        }
    }
}