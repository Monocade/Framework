using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStorageTextureReadWriteBinding
    {
        private SDL_GPUTexture* texture;

        private uint mip_level;

        private uint layer;

        private SDL_Bool cycle;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }
}