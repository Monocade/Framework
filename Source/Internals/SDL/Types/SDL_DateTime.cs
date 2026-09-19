using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_DateTime
    {
        public int Year
        {
            get => year;
            set => year = value;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }

        public int Day
        {
            get => day;
            set => day = value;
        }

        public int Hour
        {
            get => hour;
            set => hour = value;
        }

        public int Minute
        {
            get => minute;
            set => minute = value;
        }

        public int Second
        {
            get => second;
            set => second = value;
        }

        public int NanoSecond
        {
            get => nanosecond;
            set => nanosecond = value;
        }

        public int DayOfWeek
        {
            get => day_of_week;
            set => day_of_week = value;
        }

        public int UtcOffset
        {
            get => utc_offset;
            set => utc_offset = value;
        }
    }
}