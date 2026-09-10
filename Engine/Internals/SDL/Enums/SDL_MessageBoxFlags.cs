using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_MessageBoxFlags : uint
    {
	    SDL_MESSAGEBOX_ERROR = 0x00000010U,
	    SDL_MESSAGEBOX_WARNING = 0x00000020U,
	    SDL_MESSAGEBOX_INFORMATION = 0x00000040U,
	    SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = 0x00000080U,
	    SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = 0x00000100U,
    }
}