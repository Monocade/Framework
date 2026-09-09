using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MessageBoxData
    {
        private uint flags;

        private SDL_Window* window;

        private byte* title;

        private byte* message;

        private int numbuttons;

        private SDL_MessageBoxButtonData* buttons;

        private SDL_MessageBoxColorScheme* colorScheme;
    }
}