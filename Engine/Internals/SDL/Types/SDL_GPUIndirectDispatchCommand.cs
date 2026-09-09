using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndirectDispatchCommand
    {
        public uint Groupcount_x
        {
            get => groupcount_x;
            set => groupcount_x = value;
        }

        public uint Groupcount_y
        {
            get => groupcount_y;
            set => groupcount_y = value;
        }

        public uint Groupcount_z
        {
            get => groupcount_z;
            set => groupcount_z = value;
        }
    }
}