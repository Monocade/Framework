using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Texture
    {
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

        public int Refcount
        {
            get => refcount;
            set => refcount = value;
        }
    }
}