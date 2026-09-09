using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticDirection
    {
        private byte type;

        private _dir_e__FixedBuffer dir;
    }
}