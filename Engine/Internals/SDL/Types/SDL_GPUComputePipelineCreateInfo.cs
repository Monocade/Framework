using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUComputePipelineCreateInfo
    {
        public nuint Code_size
        {
            get => code_size;
            set => code_size = value;
        }

        public byte* Code
        {
            get => code;
            set => code = value;
        }

        public byte* Entrypoint
        {
            get => entrypoint;
            set => entrypoint = value;
        }

        public uint Format
        {
            get => format;
            set => format = value;
        }

        public uint Num_samplers
        {
            get => num_samplers;
            set => num_samplers = value;
        }

        public uint Num_readonly_storage_textures
        {
            get => num_readonly_storage_textures;
            set => num_readonly_storage_textures = value;
        }

        public uint Num_readonly_storage_buffers
        {
            get => num_readonly_storage_buffers;
            set => num_readonly_storage_buffers = value;
        }

        public uint Num_readwrite_storage_textures
        {
            get => num_readwrite_storage_textures;
            set => num_readwrite_storage_textures = value;
        }

        public uint Num_readwrite_storage_buffers
        {
            get => num_readwrite_storage_buffers;
            set => num_readwrite_storage_buffers = value;
        }

        public uint Num_uniform_buffers
        {
            get => num_uniform_buffers;
            set => num_uniform_buffers = value;
        }

        public uint Threadcount_x
        {
            get => threadcount_x;
            set => threadcount_x = value;
        }

        public uint Threadcount_y
        {
            get => threadcount_y;
            set => threadcount_y = value;
        }

        public uint Threadcount_z
        {
            get => threadcount_z;
            set => threadcount_z = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}