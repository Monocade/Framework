using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticDirection
    {
        public SDL_HapticDirectionType Type
        {
            get => (SDL_HapticDirectionType)type;
            set => type = (byte)value;
        }

        public _dir_e__FixedBuffer Dir
        {
            get => dir;
            set => dir = value;
        }
    }
}