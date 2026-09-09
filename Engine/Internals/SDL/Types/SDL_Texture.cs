using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Texture
    {
        private SDL_PixelFormat format;

        private int w;

        private int h;

        private int refcount;
    }
}