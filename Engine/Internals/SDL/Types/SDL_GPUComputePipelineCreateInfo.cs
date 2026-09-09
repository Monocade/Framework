using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUComputePipelineCreateInfo
    {
        private nuint code_size;

        private byte* code;

        private byte* entrypoint;

        private uint format;

        private uint num_samplers;

        private uint num_readonly_storage_textures;

        private uint num_readonly_storage_buffers;

        private uint num_readwrite_storage_textures;

        private uint num_readwrite_storage_buffers;

        private uint num_uniform_buffers;

        private uint threadcount_x;

        private uint threadcount_y;

        private uint threadcount_z;

        private uint props;
    }
}