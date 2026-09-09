using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPURenderStateCreateInfo
    {
        public SDL_GPUShader* Fragment_shader
        {
            get => fragment_shader;
            set => fragment_shader = value;
        }

        public int Num_sampler_bindings
        {
            get => num_sampler_bindings;
            set => num_sampler_bindings = value;
        }

        public SDL_GPUTextureSamplerBinding* Sampler_bindings
        {
            get => sampler_bindings;
            set => sampler_bindings = value;
        }

        public int Num_storage_textures
        {
            get => num_storage_textures;
            set => num_storage_textures = value;
        }

        public SDL_GPUTexture** Storage_textures
        {
            get => storage_textures;
            set => storage_textures = value;
        }

        public int Num_storage_buffers
        {
            get => num_storage_buffers;
            set => num_storage_buffers = value;
        }

        public SDL_GPUBuffer** Storage_buffers
        {
            get => storage_buffers;
            set => storage_buffers = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}