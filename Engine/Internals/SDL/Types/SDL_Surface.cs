using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Surface
    {
        private uint flags;

        private SDL_PixelFormat format;

        private int w;

        private int h;

        private int pitch;

        private IntPtr pixels;

        private int refcount;

        private IntPtr reserved;
    }
}