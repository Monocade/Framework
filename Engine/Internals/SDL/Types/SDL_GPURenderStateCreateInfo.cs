using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPURenderStateCreateInfo
    {
        private SDL_GPUShader* fragment_shader;

        private int num_sampler_bindings;

        private SDL_GPUTextureSamplerBinding* sampler_bindings;

        private int num_storage_textures;

        private SDL_GPUTexture** storage_textures;

        private int num_storage_buffers;

        private SDL_GPUBuffer** storage_buffers;

        private uint props;
    }
}