using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticLeftRight
    {
        private ushort type;

        private uint length;

        private ushort large_magnitude;

        private ushort small_magnitude;
    }
}