using Engine.SDL3;
using System;

namespace Engine
{
    internal sealed unsafe class SDL_NativeProvider : NativeProvider
    {
        public override byte* Allocate(nuint size)
        {
            return (byte*)SDL_malloc(size);
        }

        public override void Free(byte* ptr)
        {
            SDL_free((IntPtr)ptr);
        }
    }
}