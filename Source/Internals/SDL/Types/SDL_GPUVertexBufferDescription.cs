using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexBufferDescription
    {
        public uint Slot
        {
            get => slot;
            set => slot = value;
        }

        public uint Pitch
        {
            get => pitch;
            set => pitch = value;
        }

        public SDL_GPUVertexInputRate InputRate
        {
            get => input_rate;
            set => input_rate = value;
        }

        public uint InstanceStepRate
        {
            get => instance_step_rate;
            set => instance_step_rate = value;
        }
    }
}