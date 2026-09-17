using Engine.SDL3;
using System;

namespace Engine
{
    internal sealed unsafe class SDLNativeProvider : NativeProvider
    {
        public override IntPtr Allocate(UIntPtr size)
        {
            return SDL_malloc(size);
        }

        public override void Free(IntPtr ptr)
        {
            SDL_free(ptr);
        }
    }
}