using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GLContextReleaseFlag : uint
    {
	    SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000,
	    SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x0001,
    }
}