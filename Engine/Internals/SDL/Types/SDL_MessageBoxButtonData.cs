using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MessageBoxButtonData
    {
        public SDL_MessageBoxButtonFlags Flags
        {
            get => (SDL_MessageBoxButtonFlags)flags;
            set => flags = (uint)value;
        }

        public int ButtonID
        {
            get => buttonID;
            set => buttonID = value;
        }

        public byte* Text
        {
            get => text;
            set => text = value;
        }
    }
}