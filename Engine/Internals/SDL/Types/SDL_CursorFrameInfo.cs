using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_CursorFrameInfo
    {
        private SDL_Surface* surface;

        private uint duration;
    }
}