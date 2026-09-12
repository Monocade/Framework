using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPURenderStateCreateInfo
    {
        public SDL_GPUShader* FragmentShader
        {
            get => fragment_shader;
            set => fragment_shader = value;
        }

        public int NumSamplerBindings
        {
            get => num_sampler_bindings;
            set => num_sampler_bindings = value;
        }

        public SDL_GPUTextureSamplerBinding* SamplerBindings
        {
            get => sampler_bindings;
            set => sampler_bindings = value;
        }

        public int NumStorageTextures
        {
            get => num_storage_textures;
            set => num_storage_textures = value;
        }

        public SDL_GPUTexture** StorageTextures
        {
            get => storage_textures;
            set => storage_textures = value;
        }

        public int NumStorageBuffers
        {
            get => num_storage_buffers;
            set => num_storage_buffers = value;
        }

        public SDL_GPUBuffer** StorageBuffers
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