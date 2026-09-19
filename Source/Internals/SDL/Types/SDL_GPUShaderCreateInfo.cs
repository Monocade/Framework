using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUShaderCreateInfo
    {
        public UIntPtr CodeSize
        {
            get => code_size;
            set => code_size = value;
        }

        public byte* Code
        {
            get => code;
            set => code = value;
        }

        public byte* EntryPoint
        {
            get => entrypoint;
            set => entrypoint = value;
        }

        public SDL_GPUShaderFormat Format
        {
            get => (SDL_GPUShaderFormat)format;
            set => format = (uint)value;
        }

        public SDL_GPUShaderStage Stage
        {
            get => stage;
            set => stage = value;
        }

        public uint NumSamplers
        {
            get => num_samplers;
            set => num_samplers = value;
        }

        public uint NumStorageTextures
        {
            get => num_storage_textures;
            set => num_storage_textures = value;
        }

        public uint NumStorageBuffers
        {
            get => num_storage_buffers;
            set => num_storage_buffers = value;
        }

        public uint NumUniformBuffers
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