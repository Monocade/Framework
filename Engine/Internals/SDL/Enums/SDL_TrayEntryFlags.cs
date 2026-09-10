using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_TrayEntryFlags : uint
    {
	    SDL_TRAYENTRY_BUTTON = 0x00000001U,
	    SDL_TRAYENTRY_CHECKBOX = 0x00000002U,
	    SDL_TRAYENTRY_SUBMENU = 0x00000004U,
	    SDL_TRAYENTRY_DISABLED = 0x80000000U,
	    SDL_TRAYENTRY_CHECKED = 0x40000000U,
    }
}