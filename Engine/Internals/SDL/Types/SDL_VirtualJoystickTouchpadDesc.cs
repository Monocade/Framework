using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_VirtualJoystickTouchpadDesc
    {
        public ushort Nfingers
        {
            get => nfingers;
            set => nfingers = value;
        }
    }
}