using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Surface
    {
        public SDL_SurfaceFlags Flags
        {
            get => (SDL_SurfaceFlags)flags;
            set => flags = (uint)value;
        }

        public SDL_PixelFormat Format
        {
            get => format;
            set => format = value;
        }

        public int W
        {
            get => w;
            set => w = value;
        }

        public int H
        {
            get => h;
            set => h = value;
        }

        public int Pitch
        {
            get => pitch;
            set => pitch = value;
        }

        public IntPtr Pixels
        {
            get => pixels;
            set => pixels = value;
        }

        public int Refcount
        {
            get => refcount;
            set => refcount = value;
        }

        public IntPtr Reserved
        {
            get => reserved;
            set => reserved = value;
        }
    }
}