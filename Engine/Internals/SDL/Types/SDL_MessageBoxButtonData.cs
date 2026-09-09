using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MessageBoxButtonData
    {
        public uint Flags
        {
            get => flags;
            set => flags = value;
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