using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndexedIndirectDrawCommand
    {
        public uint Num_indices
        {
            get => num_indices;
            set => num_indices = value;
        }

        public uint Num_instances
        {
            get => num_instances;
            set => num_instances = value;
        }

        public uint First_index
        {
            get => first_index;
            set => first_index = value;
        }

        public int Vertex_offset
        {
            get => vertex_offset;
            set => vertex_offset = value;
        }

        public uint First_instance
        {
            get => first_instance;
            set => first_instance = value;
        }
    }
}