using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_PathInfo
    {
        public SDL_PathType Type
        {
            get => type;
            set => type = value;
        }

        public ulong Size
        {
            get => size;
            set => size = value;
        }

        public long Create_time
        {
            get => create_time;
            set => create_time = value;
        }

        public long Modify_time
        {
            get => modify_time;
            set => modify_time = value;
        }

        public long Access_time
        {
            get => access_time;
            set => access_time = value;
        }
    }
}