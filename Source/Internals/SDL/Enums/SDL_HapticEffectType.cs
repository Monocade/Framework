using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_HapticEffectType : ushort
    {
	    SDL_HAPTIC_CONSTANT = (1 << 0),
	    SDL_HAPTIC_SINE = (1 << 1),
	    SDL_HAPTIC_SQUARE = (1 << 2),
	    SDL_HAPTIC_TRIANGLE = (1 << 3),
	    SDL_HAPTIC_SAWTOOTHUP = (1 << 4),
	    SDL_HAPTIC_SAWTOOTHDOWN = (1 << 5),
	    SDL_HAPTIC_RAMP = (1 << 6),
	    SDL_HAPTIC_SPRING = (1 << 7),
	    SDL_HAPTIC_DAMPER = (1 << 8),
	    SDL_HAPTIC_INERTIA = (1 << 9),
	    SDL_HAPTIC_FRICTION = (1 << 10),
	    SDL_HAPTIC_LEFTRIGHT = (1 << 11),
	    SDL_HAPTIC_RESERVED1 = (1 << 12),
	    SDL_HAPTIC_RESERVED2 = (1 << 13),
	    SDL_HAPTIC_RESERVED3 = (1 << 14),
	    SDL_HAPTIC_CUSTOM = (1 << 15),
    }
}