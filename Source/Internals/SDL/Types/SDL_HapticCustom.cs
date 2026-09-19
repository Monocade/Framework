using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticCustom
    {
        public SDL_HapticEffectType Type
        {
            get => (SDL_HapticEffectType)type;
            set => type = (ushort)value;
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

        public byte Channels
        {
            get => channels;
            set => channels = value;
        }

        public ushort Period
        {
            get => period;
            set => period = value;
        }

        public ushort Samples
        {
            get => samples;
            set => samples = value;
        }

        public ushort* Data
        {
            get => data;
            set => data = value;
        }

        public ushort AttackLength
        {
            get => attack_length;
            set => attack_length = value;
        }

        public ushort AttackLevel
        {
            get => attack_level;
            set => attack_level = value;
        }

        public ushort FadeLength
        {
            get => fade_length;
            set => fade_length = value;
        }

        public ushort FadeLevel
        {
            get => fade_level;
            set => fade_level = value;
        }
    }
}