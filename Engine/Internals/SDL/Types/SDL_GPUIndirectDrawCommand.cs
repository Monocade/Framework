using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUIndirectDrawCommand
    {
        public uint NumVertices
        {
            get => num_vertices;
            set => num_vertices = value;
        }

        public uint NumInstances
        {
            get => num_instances;
            set => num_instances = value;
        }

        public uint FirstVertex
        {
            get => first_vertex;
            set => first_vertex = value;
        }

        public uint FirstInstance
        {
            get => first_instance;
            set => first_instance = value;
        }
    }
}