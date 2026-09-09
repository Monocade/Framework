using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexInputState
    {
        private SDL_GPUVertexBufferDescription* vertex_buffer_descriptions;

        private uint num_vertex_buffers;

        private SDL_GPUVertexAttribute* vertex_attributes;

        private uint num_vertex_attributes;
    }
}