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

        public SDL_Bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }

        public byte Padding1
        {
            get => padding1;
            set => padding1 = value;
        }

        public byte Padding2
        {
            get => padding2;
            set => padding2 = value;
        }

        public byte Padding3
        {
            get => padding3;
            set => padding3 = value;
        }
    }
}