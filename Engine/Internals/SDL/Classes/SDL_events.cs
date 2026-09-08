using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_PumpEvents()
        {
            iSDL_PumpEvents();
        }

        public static int SDL_PeepEvents(out SDL_Event[] events, int numevents, SDL_EventAction action, uint minType, uint maxType)
        {
            events = new SDL_Event[numevents];
            {
                fixed (SDL_Event* ptr1 = events)
                {
                    return iSDL_PeepEvents(ptr1, numevents, action, minType, maxType);
                }
            }
        }

        public static bool SDL_HasEvent(uint type)
        {
            return iSDL_HasEvent(type);
        }

        public static bool SDL_HasEvents(uint minType, uint maxType)
        {
            return iSDL_HasEvents(minType, maxType);
        }

        public static void SDL_FlushEvent(uint type)
        {
            iSDL_FlushEvent(type);
        }

        public static void SDL_FlushEvents(uint minType, uint maxType)
        {
            iSDL_FlushEvents(minType, maxType);
        }

        public static bool SDL_PollEvent(out SDL_Event @event)
        {
            fixed (SDL_Event* ptr1 = &@event)
            {
                return iSDL_PollEvent(ptr1);
            }
        }

        public static bool SDL_WaitEvent(out SDL_Event @event)
        {
            fixed (SDL_Event* ptr1 = &@event)
            {
                return iSDL_WaitEvent(ptr1);
            }
        }

        public static bool SDL_WaitEventTimeout(out SDL_Event @event, int timeoutMS)
        {
            fixed (SDL_Event* ptr1 = &@event)
            {
                return iSDL_WaitEventTimeout(ptr1, timeoutMS);
            }
        }

        public static bool SDL_PushEvent(SDL_Event* @event)
        {
            return iSDL_PushEvent(@event);
        }

        public static void SDL_SetEventFilter(SDL_EventFilter filter, IntPtr userdata)
        {
            iSDL_SetEventFilter(Marshal.GetFunctionPointerForDelegate(filter), userdata);
        }

        public static bool SDL_GetEventFilter(out SDL_EventFilter filter, out IntPtr userdata)
        {
            IntPtr ptr1 = IntPtr.Zero;
            fixed (IntPtr* ptr2 = &userdata)
            {
                var result = iSDL_GetEventFilter(&ptr1, ptr2);
                filter = Marshal.GetDelegateForFunctionPointer<SDL_EventFilter>(ptr1);
                return result;
            }
        }

        public static bool SDL_AddEventWatch(SDL_EventFilter filter, IntPtr userdata)
        {
            return iSDL_AddEventWatch(Marshal.GetFunctionPointerForDelegate(filter), userdata);
        }

        public static void SDL_RemoveEventWatch(SDL_EventFilter filter, IntPtr userdata)
        {
            iSDL_RemoveEventWatch(Marshal.GetFunctionPointerForDelegate(filter), userdata);
        }

        public static void SDL_FilterEvents(SDL_EventFilter filter, IntPtr userdata)
        {
            iSDL_FilterEvents(Marshal.GetFunctionPointerForDelegate(filter), userdata);
        }

        public static void SDL_SetEventEnabled(uint type, bool enabled)
        {
            iSDL_SetEventEnabled(type, enabled);
        }

        public static bool SDL_EventEnabled(uint type)
        {
            return iSDL_EventEnabled(type);
        }

        public static uint SDL_RegisterEvents(int numevents)
        {
            return iSDL_RegisterEvents(numevents);
        }

        public static SDL_Window* SDL_GetWindowFromEvent(SDL_Event* @event)
        {
            return iSDL_GetWindowFromEvent(@event);
        }

        public static int SDL_GetEventDescription(SDL_Event* @event, string buf, int buflen)
        {
            fixed (byte* ptr1 = SDL_StringToNative(buf))
            {
                return iSDL_GetEventDescription(@event, ptr1, buflen);
            }
        }
    }
}