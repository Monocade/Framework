using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndirectDrawCommand
    {
        private uint num_vertices;

        private uint num_instances;

        private uint first_vertex;

        private uint first_instance;
    }
}