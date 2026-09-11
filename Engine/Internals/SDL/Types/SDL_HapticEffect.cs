using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticEffect
    {
        public SDL_HapticEffectType Type
        {
            get => (SDL_HapticEffectType)type;
            set => type = (ushort)value;
        }

        public SDL_HapticConstant Constant
        {
            get => constant;
            set => constant = value;
        }

        public SDL_HapticPeriodic Periodic
        {
            get => periodic;
            set => periodic = value;
        }

        public SDL_HapticCondition Condition
        {
            get => condition;
            set => condition = value;
        }

        public SDL_HapticRamp Ramp
        {
            get => ramp;
            set => ramp = value;
        }

        public SDL_HapticLeftRight Leftright
        {
            get => leftright;
            set => leftright = value;
        }

        public SDL_HapticCustom Custom
        {
            get => custom;
            set => custom = value;
        }
    }
}