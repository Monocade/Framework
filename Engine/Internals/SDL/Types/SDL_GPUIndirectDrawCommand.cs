using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndirectDrawCommand
    {
        public uint Num_vertices
        {
            get => num_vertices;
            set => num_vertices = value;
        }

        public uint Num_instances
        {
            get => num_instances;
            set => num_instances = value;
        }

        public uint First_vertex
        {
            get => first_vertex;
            set => first_vertex = value;
        }

        public uint First_instance
        {
            get => first_instance;
            set => first_instance = value;
        }
    }
}