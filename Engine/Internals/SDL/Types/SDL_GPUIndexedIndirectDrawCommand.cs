using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndexedIndirectDrawCommand
    {
        private uint num_indices;

        private uint num_instances;

        private uint first_index;

        private int vertex_offset;

        private uint first_instance;
    }
}