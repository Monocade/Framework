using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticCondition
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private _right_sat_e__FixedBuffer right_sat;

        private _left_sat_e__FixedBuffer left_sat;

        private _right_coeff_e__FixedBuffer right_coeff;

        private _left_coeff_e__FixedBuffer left_coeff;

        private _deadband_e__FixedBuffer deadband;

        private _center_e__FixedBuffer center;
    }
}