using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndexedIndirectDrawCommand
    {
        public uint NumIndices
        {
            get => num_indices;
            set => num_indices = value;
        }

        public uint NumInstances
        {
            get => num_instances;
            set => num_instances = value;
        }

        public uint FirstIndex
        {
            get => first_index;
            set => first_index = value;
        }

        public int VertexOffset
        {
            get => vertex_offset;
            set => vertex_offset = value;
        }

        public uint FirstInstance
        {
            get => first_instance;
            set => first_instance = value;
        }
    }
}