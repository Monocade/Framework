using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticLeftRight
    {
        public SDL_HapticEffectType Type
        {
            get => (SDL_HapticEffectType)type;
            set => type = (ushort)value;
        }

        public uint Length
        {
            get => length;
            set => length = value;
        }

        public ushort LargeMagnitude
        {
            get => large_magnitude;
            set => large_magnitude = value;
        }

        public ushort SmallMagnitude
        {
            get => small_magnitude;
            set => small_magnitude = value;
        }
    }
}