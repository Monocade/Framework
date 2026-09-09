using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_VirtualJoystickSensorDesc
    {
        public SDL_SensorType Type
        {
            get => type;
            set => type = value;
        }

        public float Rate
        {
            get => rate;
            set => rate = value;
        }
    }
}