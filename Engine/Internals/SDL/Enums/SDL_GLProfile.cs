using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GLProfile : uint
    {
	    SDL_GL_CONTEXT_PROFILE_CORE = 0x0001,
	    SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002,
	    SDL_GL_CONTEXT_PROFILE_ES = 0x0004,
    }
}