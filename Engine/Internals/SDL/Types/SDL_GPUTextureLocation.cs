using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureLocation
    {
        private SDL_GPUTexture* texture;

        private uint mip_level;

        private uint layer;

        private uint x;

        private uint y;

        private uint z;
    }
}