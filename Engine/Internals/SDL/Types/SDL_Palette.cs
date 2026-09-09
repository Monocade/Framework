using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Palette
    {
        private int ncolors;

        private SDL_Color* colors;

        private uint version;

        private int refcount;
    }
}