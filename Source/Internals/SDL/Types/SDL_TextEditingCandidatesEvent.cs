using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_TextEditingCandidatesEvent
    {
        public SDL_EventType Type
        {
            get => type;
            set => type = value;
        }

        public uint Reserved
        {
            get => reserved;
            set => reserved = value;
        }

        public ulong Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

        public uint WindowID
        {
            get => windowID;
            set => windowID = value;
        }

        public byte** Candidates
        {
            get => candidates;
            set => candidates = value;
        }

        public int NumCandidates
        {
            get => num_candidates;
            set => num_candidates = value;
        }

        public int SelectedCandidate
        {
            get => selected_candidate;
            set => selected_candidate = value;
        }

        public bool Horizontal
        {
            get => horizontal;
            set => horizontal = value;
        }
    }
}