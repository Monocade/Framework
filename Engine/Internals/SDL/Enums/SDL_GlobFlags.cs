using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GlobFlags : uint
    {
	    SDL_GLOB_CASESENSITIVE = 0,
	    SDL_GLOB_CASEINSENSITIVE = (1U << 0),
    }
}