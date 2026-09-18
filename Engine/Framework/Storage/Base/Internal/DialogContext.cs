using System;

namespace Engine
{
    internal readonly struct DialogContext
    {
        internal readonly SDL_DialogFileFilter[] NativeFilters;
        internal readonly FileSystem.DialogCallback Callback;
        internal readonly DialogMode Mode;
        internal readonly string Path;
        
        
        internal DialogContext(string path, FileSystem.DialogCallback callback, SDL_DialogFileFilter[] nativeFilters, DialogMode mode)
        {
            NativeFilters = nativeFilters;
            Callback = callback;
            Path = path;
            Mode = mode;
        }
    }
}