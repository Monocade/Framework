using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MessageBoxData
    {
        public SDL_MessageBoxFlags Flags
        {
            get => (SDL_MessageBoxFlags)flags;
            set => flags = (uint)value;
        }

        public SDL_Window* Window
        {
            get => window;
            set => window = value;
        }

        public byte* Title
        {
            get => title;
            set => title = value;
        }

        public byte* Message
        {
            get => message;
            set => message = value;
        }

        public int NumButtons
        {
            get => numbuttons;
            set => numbuttons = value;
        }

        public SDL_MessageBoxButtonData* Buttons
        {
            get => buttons;
            set => buttons = value;
        }

        public SDL_MessageBoxColorScheme* ColorScheme
        {
            get => colorScheme;
            set => colorScheme = value;
        }
    }
}