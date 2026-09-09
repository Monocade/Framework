using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticPeriodic
    {
        public ushort Type
        {
            get => type;
            set => type = value;
        }

        public SDL_HapticDirection Direction
        {
            get => direction;
            set => direction = value;
        }

        public uint Length
        {
            get => length;
            set => length = value;
        }

        public ushort Delay
        {
            get => delay;
            set => delay = value;
        }

        public ushort Button
        {
            get => button;
            set => button = value;
        }

        public ushort Interval
        {
            get => interval;
            set => interval = value;
        }

        public ushort Period
        {
            get => period;
            set => period = value;
        }

        public short Magnitude
        {
            get => magnitude;
            set => magnitude = value;
        }

        public short Offset
        {
            get => offset;
            set => offset = value;
        }

        public ushort Phase
        {
            get => phase;
            set => phase = value;
        }

        public ushort Attack_length
        {
            get => attack_length;
            set => attack_length = value;
        }

        public ushort Attack_level
        {
            get => attack_level;
            set => attack_level = value;
        }

        public ushort Fade_length
        {
            get => fade_length;
            set => fade_length = value;
        }

        public ushort Fade_level
        {
            get => fade_level;
            set => fade_level = value;
        }
    }
}