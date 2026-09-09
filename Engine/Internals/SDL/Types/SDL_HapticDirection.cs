using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticDirection
    {
        public byte Type
        {
            get => type;
            set => type = value;
        }

        public _dir_e__FixedBuffer Dir
        {
            get => dir;
            set => dir = value;
        }
    }
}