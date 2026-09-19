using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexInputState
    {
        public SDL_GPUVertexBufferDescription* VertexBufferDescriptions
        {
            get => vertex_buffer_descriptions;
            set => vertex_buffer_descriptions = value;
        }

        public uint NumVertexBuffers
        {
            get => num_vertex_buffers;
            set => num_vertex_buffers = value;
        }

        public SDL_GPUVertexAttribute* VertexAttributes
        {
            get => vertex_attributes;
            set => vertex_attributes = value;
        }

        public uint NumVertexAttributes
        {
            get => num_vertex_attributes;
            set => num_vertex_attributes = value;
        }
    }
}