using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticCondition
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

        public _right_sat_e__FixedBuffer Right_sat
        {
            get => right_sat;
            set => right_sat = value;
        }

        public _left_sat_e__FixedBuffer Left_sat
        {
            get => left_sat;
            set => left_sat = value;
        }

        public _right_coeff_e__FixedBuffer Right_coeff
        {
            get => right_coeff;
            set => right_coeff = value;
        }

        public _left_coeff_e__FixedBuffer Left_coeff
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