using System;

namespace Engine
{
    internal readonly struct DialogContext
    {
        public readonly SDL_DialogFileFilter[] NativeFilters;
        public readonly FileSystem.DialogCallback Callback;
        public readonly DialogMode Mode;
        public readonly string Path;

        public DialogContext(string path, FileSystem.DialogCallback callback, SDL_DialogFileFilter[] nativeFilters, DialogMode mode)
        {
            this.NativeFilters = nativeFilters;
            this.Callback = callback;
            this.Path = path;
            this.Mode = mode;
        }
    }
}