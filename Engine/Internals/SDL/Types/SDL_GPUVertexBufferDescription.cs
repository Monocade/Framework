using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexBufferDescription
    {
        private uint slot;

        private uint pitch;

        private SDL_GPUVertexInputRate input_rate;

        private uint instance_step_rate;
    }
}