using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_VirtualJoystickSensorDesc
    {
        private SDL_SensorType type;

        private float rate;
    }
}