using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_GetDateTimeLocalePreferences(out SDL_DateFormat dateFormat, out SDL_TimeFormat timeFormat)
        {
            fixed (SDL_DateFormat* ptr1 = &dateFormat)
            fixed (SDL_TimeFormat* ptr2 = &timeFormat)
            {
                return iSDL_GetDateTimeLocalePreferences(ptr1, ptr2);
            }
        }

        public static bool SDL_GetCurrentTime(ref long ticks)
        {
            fixed (long* ptr1 = &ticks)
            {
                return iSDL_GetCurrentTime(ptr1);
            }
        }

        public static bool SDL_TimeToDateTime(long ticks, out SDL_DateTime dt, bool localTime)
        {
            fixed (SDL_DateTime* ptr1 = &dt)
            {
                return iSDL_TimeToDateTime(ticks, ptr1, localTime);
            }
        }

        public static bool SDL_DateTimeToTime(SDL_DateTime* dt, out long ticks)
        {
            fixed (long* ptr1 = &ticks)
            {
                return iSDL_DateTimeToTime(dt, ptr1);
            }
        }

        public static void SDL_TimeToWindows(long ticks, out uint dwLowDateTime, out uint dwHighDateTime)
        {
            fixed (uint* ptr1 = &dwLowDateTime)
            fixed (uint* ptr2 = &dwHighDateTime)
            {
                iSDL_TimeToWindows(ticks, ptr1, ptr2);
            }
        }

        public static long SDL_TimeFromWindows(uint dwLowDateTime, uint dwHighDateTime)
        {
            return iSDL_TimeFromWindows(dwLowDateTime, dwHighDateTime);
        }

        public static int SDL_GetDaysInMonth(int year, int month)
        {
            return iSDL_GetDaysInMonth(year, month);
        }

        public static int SDL_GetDayOfYear(int year, int month, int day)
        {
            return iSDL_GetDayOfYear(year, month, day);
        }

        public static int SDL_GetDayOfWeek(int year, int month, int day)
        {
            return iSDL_GetDayOfWeek(year, month, day);
        }
    }
}