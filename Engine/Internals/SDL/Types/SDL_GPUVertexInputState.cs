using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexInputState
    {
        public SDL_GPUVertexBufferDescription* Vertex_buffer_descriptions
        {
            get => vertex_buffer_descriptions;
            set => vertex_buffer_descriptions = value;
        }

        public uint Num_vertex_buffers
        {
            get => num_vertex_buffers;
            set => num_vertex_buffers = value;
        }

        public SDL_GPUVertexAttribute* Vertex_attributes
        {
            get => vertex_attributes;
            set => vertex_attributes = value;
        }

        public uint Num_vertex_attributes
        {
            get => num_vertex_attributes;
            set => num_vertex_attributes = value;
        }
    }
}