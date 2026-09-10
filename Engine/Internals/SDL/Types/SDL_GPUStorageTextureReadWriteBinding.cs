using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStorageTextureReadWriteBinding
    {
        public SDL_GPUTexture* Texture
        {
            get => texture;
            set => texture = value;
        }

        public uint Mip_level
        {
            get => mip_level;
            set => mip_level = value;
        }

        public uint Layer
        {
            get => layer;
            set => layer = value;
        }

        public bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }
    }
}