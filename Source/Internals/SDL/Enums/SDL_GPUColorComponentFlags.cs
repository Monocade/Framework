using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GPUColorComponentFlags : byte
    {
	    SDL_GPU_COLORCOMPONENT_R = (1 << 0),
	    SDL_GPU_COLORCOMPONENT_G = (1 << 1),
	    SDL_GPU_COLORCOMPONENT_B = (1 << 2),
	    SDL_GPU_COLORCOMPONENT_A = (1 << 3),
    }
}