using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_CursorFrameInfo
    {
        public SDL_Surface* Surface
        {
            get => surface;
            set => surface = value;
        }

        public uint Duration
        {
            get => duration;
            set => duration = value;
        }
    }
}