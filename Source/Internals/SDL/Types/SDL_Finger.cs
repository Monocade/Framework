using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Finger
    {
        public ulong ID
        {
            get => id;
            set => id = value;
        }

        public float X
        {
            get => x;
            set => x = value;
        }

        public float Y
        {
            get => y;
            set => y = value;
        }

        public float Pressure
        {
            get => pressure;
            set => pressure = value;
        }
    }
}