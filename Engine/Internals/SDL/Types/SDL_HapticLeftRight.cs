using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticLeftRight
    {
        public ushort Type
        {
            get => type;
            set => type = value;
        }

        public uint Length
        {
            get => length;
            set => length = value;
        }

        public ushort Large_magnitude
        {
            get => large_magnitude;
            set => large_magnitude = value;
        }

        public ushort Small_magnitude
        {
            get => small_magnitude;
            set => small_magnitude = value;
        }
    }
}