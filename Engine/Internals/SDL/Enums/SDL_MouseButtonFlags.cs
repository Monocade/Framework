using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_MouseButtonFlags : uint
    {
	    SDL_BUTTON_LMASK = (1U << ((1) - 1)),
	    SDL_BUTTON_MMASK = (1U << ((2) - 1)),
	    SDL_BUTTON_RMASK = (1U << ((3) - 1)),
	    SDL_BUTTON_X1MASK = (1U << ((4) - 1)),
	    SDL_BUTTON_X2MASK = (1U << ((5) - 1)),
    }
}