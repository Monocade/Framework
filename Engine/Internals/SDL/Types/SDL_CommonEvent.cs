using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_CommonEvent
    {
        private uint type;

        private uint reserved;

        private ulong timestamp;
    }
}