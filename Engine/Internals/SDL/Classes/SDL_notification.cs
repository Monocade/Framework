using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_RequestNotificationPermission()
        {
            return iSDL_RequestNotificationPermission();
        }

        public static uint SDL_ShowNotificationWithProperties(uint props)
        {
            return iSDL_ShowNotificationWithProperties(props);
        }

        public static uint SDL_ShowNotification(string title, string message, SDL_Surface* image, SDL_NotificationAction[] actions, int numActions)
        {
            fixed (byte* ptr1 = SDL_StringToNative(title))
            fixed (byte* ptr2 = SDL_StringToNative(message))
            fixed (SDL_NotificationAction* ptr3 = actions)
            {
                return iSDL_ShowNotification(ptr1, ptr2, image, ptr3, numActions);
            }
        }

        public static bool SDL_RemoveNotification(uint notification)
        {
            return iSDL_RemoveNotification(notification);
        }
    }
}