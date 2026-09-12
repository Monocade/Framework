using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUComputePipelineCreateInfo
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

        public byte* Entrypoint
        {
            get => entrypoint;
            set => entrypoint = value;
        }

        public SDL_GPUShaderFormat Format
        {
            get => (SDL_GPUShaderFormat)format;
            set => format = (uint)value;
        }

        public uint NumSamplers
        {
            get => num_samplers;
            set => num_samplers = value;
        }

        public uint NumReadonlyStorageTextures
        {
            get => num_readonly_storage_textures;
            set => num_readonly_storage_textures = value;
        }

        public uint NumReadonlyStorageBuffers
        {
            get => num_readonly_storage_buffers;
            set => num_readonly_storage_buffers = value;
        }

        public uint NumReadwriteStorageTextures
        {
            get => num_readwrite_storage_textures;
            set => num_readwrite_storage_textures = value;
        }

        public uint NumReadwriteStorageBuffers
        {
            get => num_readwrite_storage_buffers;
            set => num_readwrite_storage_buffers = value;
        }

        public uint NumUniformBuffers
        {
            get => num_uniform_buffers;
            set => num_uniform_buffers = value;
        }

        public uint ThreadcountX
        {
            get => threadcount_x;
            set => threadcount_x = value;
        }

        public uint ThreadcountY
        {
            get => threadcount_y;
            set => threadcount_y = value;
        }

        public uint ThreadcountZ
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