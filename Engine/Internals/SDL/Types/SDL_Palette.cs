using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Palette
    {
        public int Ncolors
        {
            get => ncolors;
            set => ncolors = value;
        }

        public SDL_Color* Colors
        {
            get => colors;
            set => colors = value;
        }

        public uint Version
        {
            get => version;
            set => version = value;
        }

        public int Refcount
        {
            get => refcount;
            set => refcount = value;
        }
    }
}