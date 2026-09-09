using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticCustom
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private byte channels;

        private ushort period;

        private ushort samples;

        private ushort* data;

        private ushort attack_length;

        private ushort attack_level;

        private ushort fade_length;

        private ushort fade_level;
    }
}