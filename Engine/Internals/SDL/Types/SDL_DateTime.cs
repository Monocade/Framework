using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_DateTime
    {
        private int year;

        private int month;

        private int day;

        private int hour;

        private int minute;

        private int second;

        private int nanosecond;

        private int day_of_week;

        private int utc_offset;
    }
}