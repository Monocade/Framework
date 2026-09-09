using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]
        private ushort type;

        [FieldOffset(0)]
        private SDL_HapticConstant constant;

        [FieldOffset(0)]
        private SDL_HapticPeriodic periodic;

        [FieldOffset(0)]
        private SDL_HapticCondition condition;

        [FieldOffset(0)]
        private SDL_HapticRamp ramp;

        [FieldOffset(0)]
        private SDL_HapticLeftRight leftright;

        [FieldOffset(0)]
        private SDL_HapticCustom custom;
    }
}