using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUShaderCreateInfo
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

        public SDL_GPUShaderStage Stage
        {
            get => stage;
            set => stage = value;
        }

        public uint Num_samplers
        {
            get => num_samplers;
            set => num_samplers = value;
        }

        public uint Num_storage_textures
        {
            get => num_storage_textures;
            set => num_storage_textures = value;
        }

        public uint Num_storage_buffers
        {
            get => num_storage_buffers;
            set => num_storage_buffers = value;
        }

        public uint Num_uniform_buffers
        {
            get => num_uniform_buffers;
            set => num_uniform_buffers = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}