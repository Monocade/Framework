using System;

namespace Engine
{
    public abstract class DialogProvider
    {
        public abstract void Open(Dialog.DialogCallback callback);
    }
}