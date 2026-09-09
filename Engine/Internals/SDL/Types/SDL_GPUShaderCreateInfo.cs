using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUShaderCreateInfo
    {
        private nuint code_size;

        private byte* code;

        private byte* entrypoint;

        private uint format;

        private SDL_GPUShaderStage stage;

        private uint num_samplers;

        private uint num_storage_textures;

        private uint num_storage_buffers;

        private uint num_uniform_buffers;

        private uint props;
    }
}