using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GLContextFlag : uint
    {
	    SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001,
	    SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002,
	    SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004,
	    SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008,
    }
}