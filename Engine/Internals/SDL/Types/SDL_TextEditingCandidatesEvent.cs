using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_TextEditingCandidatesEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private byte** candidates;

        private int num_candidates;

        private int selected_candidate;

        private SDL_Bool horizontal;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }
}