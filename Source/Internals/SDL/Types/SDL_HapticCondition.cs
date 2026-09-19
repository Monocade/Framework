using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticCondition
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

        public _right_sat_e__FixedBuffer RightSat
        {
            get => right_sat;
            set => right_sat = value;
        }

        public _left_sat_e__FixedBuffer LeftSat
        {
            get => left_sat;
            set => left_sat = value;
        }

        public _right_coeff_e__FixedBuffer RightCoefficient
        {
            get => right_coeff;
            set => right_coeff = value;
        }

        public _left_coeff_e__FixedBuffer LeftCoefficient
        {
            get => left_coeff;
            set => left_coeff = value;
        }

        public _deadband_e__FixedBuffer Deadband
        {
            get => deadband;
            set => deadband = value;
        }

        public _center_e__FixedBuffer Center
        {
            get => center;
            set => center = value;
        }
    }
}