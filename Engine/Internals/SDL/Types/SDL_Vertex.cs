using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Vertex
    {
        private SDL_FPoint position;

        private SDL_FColor color;

        private SDL_FPoint tex_coord;
    }
}