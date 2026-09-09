using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Vertex
    {
        public SDL_FPoint Position
        {
            get => position;
            set => position = value;
        }

        public SDL_FColor Color
        {
            get => color;
            set => color = value;
        }

        public SDL_FPoint Tex_coord
        {
            get => tex_coord;
            set => tex_coord = value;
        }
    }
}