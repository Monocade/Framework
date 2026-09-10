using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_MessageBoxButtonFlags : uint
    {
	    SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = 0x00000001U,
	    SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = 0x00000002U,
    }
}