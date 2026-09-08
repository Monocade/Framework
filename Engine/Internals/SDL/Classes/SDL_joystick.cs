using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_LockJoysticks()
        {
            iSDL_LockJoysticks();
        }

        public static bool SDL_TryLockJoysticks()
        {
            return iSDL_TryLockJoysticks();
        }

        public static void SDL_UnlockJoysticks()
        {
            iSDL_UnlockJoysticks();
        }

        public static bool SDL_HasJoystick()
        {
            return iSDL_HasJoystick();
        }

        public static uint[] SDL_GetJoysticks(out int count)
        {
            return SDL_NativeToArray(iSDL_GetJoysticks(null), out count);
        }

        public static string SDL_GetJoystickNameForID(uint instance_id)
        {
            return SDL_NativeToString(iSDL_GetJoystickNameForID(instance_id));
        }

        public static string SDL_GetJoystickPathForID(uint instance_id)
        {
            return SDL_NativeToString(iSDL_GetJoystickPathForID(instance_id));
        }

        public static int SDL_GetJoystickPlayerIndexForID(uint instance_id)
        {
            return iSDL_GetJoystickPlayerIndexForID(instance_id);
        }

        public static SDL_GUID SDL_GetJoystickGUIDForID(uint instance_id)
        {
            return iSDL_GetJoystickGUIDForID(instance_id);
        }

        public static ushort SDL_GetJoystickVendorForID(uint instance_id)
        {
            return iSDL_GetJoystickVendorForID(instance_id);
        }

        public static ushort SDL_GetJoystickProductForID(uint instance_id)
        {
            return iSDL_GetJoystickProductForID(instance_id);
        }

        public static ushort SDL_GetJoystickProductVersionForID(uint instance_id)
        {
            return iSDL_GetJoystickProductVersionForID(instance_id);
        }

        public static SDL_JoystickType SDL_GetJoystickTypeForID(uint instance_id)
        {
            return iSDL_GetJoystickTypeForID(instance_id);
        }

        public static SDL_Joystick* SDL_OpenJoystick(uint instance_id)
        {
            return iSDL_OpenJoystick(instance_id);
        }

        public static SDL_Joystick* SDL_GetJoystickFromID(uint instance_id)
        {
            return iSDL_GetJoystickFromID(instance_id);
        }

        public static SDL_Joystick* SDL_GetJoystickFromPlayerIndex(int player_index)
        {
            return iSDL_GetJoystickFromPlayerIndex(player_index);
        }

        public static uint SDL_AttachVirtualJoystick(SDL_VirtualJoystickDesc* desc)
        {
            return iSDL_AttachVirtualJoystick(desc);
        }

        public static bool SDL_DetachVirtualJoystick(uint instance_id)
        {
            return iSDL_DetachVirtualJoystick(instance_id);
        }

        public static bool SDL_IsJoystickVirtual(uint instance_id)
        {
            return iSDL_IsJoystickVirtual(instance_id);
        }

        public static bool SDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, short value)
        {
            return iSDL_SetJoystickVirtualAxis(joystick, axis, value);
        }

        public static bool SDL_SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, short xrel, short yrel)
        {
            return iSDL_SetJoystickVirtualBall(joystick, ball, xrel, yrel);
        }

        public static bool SDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, bool down)
        {
            return iSDL_SetJoystickVirtualButton(joystick, button, down);
        }

        public static bool SDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, byte value)
        {
            return iSDL_SetJoystickVirtualHat(joystick, hat, value);
        }

        public static bool SDL_SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, bool down, float x, float y, float pressure)
        {
            return iSDL_SetJoystickVirtualTouchpad(joystick, touchpad, finger, down, x, y, pressure);
        }

        public static bool SDL_SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, ulong sensor_timestamp, out float[] data, int num_values)
        {
            data = new float[num_values];
            {
                fixed (float* ptr1 = data)
                {
                    return iSDL_SendJoystickVirtualSensorData(joystick, type, sensor_timestamp, ptr1, num_values);
                }
            }
        }

        public static uint SDL_GetJoystickProperties(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickProperties(joystick);
        }

        public static string SDL_GetJoystickName(SDL_Joystick* joystick)
        {
            return SDL_NativeToString(iSDL_GetJoystickName(joystick));
        }

        public static string SDL_GetJoystickPath(SDL_Joystick* joystick)
        {
            return SDL_NativeToString(iSDL_GetJoystickPath(joystick));
        }

        public static int SDL_GetJoystickPlayerIndex(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickPlayerIndex(joystick);
        }

        public static bool SDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index)
        {
            return iSDL_SetJoystickPlayerIndex(joystick, player_index);
        }

        public static SDL_GUID SDL_GetJoystickGUID(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickGUID(joystick);
        }

        public static ushort SDL_GetJoystickVendor(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickVendor(joystick);
        }

        public static ushort SDL_GetJoystickProduct(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickProduct(joystick);
        }

        public static ushort SDL_GetJoystickProductVersion(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickProductVersion(joystick);
        }

        public static ushort SDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickFirmwareVersion(joystick);
        }

        public static string SDL_GetJoystickSerial(SDL_Joystick* joystick)
        {
            return SDL_NativeToString(iSDL_GetJoystickSerial(joystick));
        }

        public static SDL_JoystickType SDL_GetJoystickType(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickType(joystick);
        }

        public static void SDL_GetJoystickGUIDInfo(SDL_GUID guid, out ushort vendor, out ushort product, out ushort version, out ushort crc16)
        {
            fixed (ushort* ptr1 = &vendor)
            fixed (ushort* ptr2 = &product)
            fixed (ushort* ptr3 = &version)
            fixed (ushort* ptr4 = &crc16)
            {
                iSDL_GetJoystickGUIDInfo(guid, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_JoystickConnected(SDL_Joystick* joystick)
        {
            return iSDL_JoystickConnected(joystick);
        }

        public static uint SDL_GetJoystickID(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickID(joystick);
        }

        public static int SDL_GetNumJoystickAxes(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickAxes(joystick);
        }

        public static int SDL_GetNumJoystickBalls(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickBalls(joystick);
        }

        public static int SDL_GetNumJoystickHats(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickHats(joystick);
        }

        public static int SDL_GetNumJoystickButtons(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickButtons(joystick);
        }

        public static void SDL_SetJoystickEventsEnabled(bool enabled)
        {
            iSDL_SetJoystickEventsEnabled(enabled);
        }

        public static bool SDL_JoystickEventsEnabled()
        {
            return iSDL_JoystickEventsEnabled();
        }

        public static void SDL_UpdateJoysticks()
        {
            iSDL_UpdateJoysticks();
        }

        public static short SDL_GetJoystickAxis(SDL_Joystick* joystick, int axis)
        {
            return iSDL_GetJoystickAxis(joystick, axis);
        }

        public static bool SDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, out short state)
        {
            fixed (short* ptr1 = &state)
            {
                return iSDL_GetJoystickAxisInitialState(joystick, axis, ptr1);
            }
        }

        public static bool SDL_GetJoystickBall(SDL_Joystick* joystick, int ball, out int dx, out int dy)
        {
            fixed (int* ptr1 = &dx)
            fixed (int* ptr2 = &dy)
            {
                return iSDL_GetJoystickBall(joystick, ball, ptr1, ptr2);
            }
        }

        public static byte SDL_GetJoystickHat(SDL_Joystick* joystick, int hat)
        {
            return iSDL_GetJoystickHat(joystick, hat);
        }

        public static bool SDL_GetJoystickButton(SDL_Joystick* joystick, int button)
        {
            return iSDL_GetJoystickButton(joystick, button);
        }

        public static bool SDL_JoystickHasSensor(SDL_Joystick* joystick, SDL_SensorType type)
        {
            return iSDL_JoystickHasSensor(joystick, type);
        }

        public static bool SDL_SetJoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type, bool enabled)
        {
            return iSDL_SetJoystickSensorEnabled(joystick, type, enabled);
        }

        public static bool SDL_JoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type)
        {
            return iSDL_JoystickSensorEnabled(joystick, type);
        }

        public static float SDL_GetJoystickSensorDataRate(SDL_Joystick* joystick, SDL_SensorType type)
        {
            return iSDL_GetJoystickSensorDataRate(joystick, type);
        }

        public static bool SDL_GetJoystickSensorData(SDL_Joystick* joystick, SDL_SensorType type, out float[] data, int num_values)
        {
            data = new float[num_values];
            {
                fixed (float* ptr1 = data)
                {
                    return iSDL_GetJoystickSensorData(joystick, type, ptr1, num_values);
                }
            }
        }

        public static bool SDL_RumbleJoystick(SDL_Joystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms)
        {
            return iSDL_RumbleJoystick(joystick, low_frequency_rumble, high_frequency_rumble, duration_ms);
        }

        public static bool SDL_RumbleJoystickTriggers(SDL_Joystick* joystick, ushort left_rumble, ushort right_rumble, uint duration_ms)
        {
            return iSDL_RumbleJoystickTriggers(joystick, left_rumble, right_rumble, duration_ms);
        }

        public static bool SDL_SetJoystickLED(SDL_Joystick* joystick, byte red, byte green, byte blue)
        {
            return iSDL_SetJoystickLED(joystick, red, green, blue);
        }

        public static bool SDL_SendJoystickEffect(SDL_Joystick* joystick, IntPtr data, int size)
        {
            return iSDL_SendJoystickEffect(joystick, data, size);
        }

        public static void SDL_CloseJoystick(SDL_Joystick* joystick)
        {
            iSDL_CloseJoystick(joystick);
        }

        public static SDL_JoystickConnectionState SDL_GetJoystickConnectionState(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickConnectionState(joystick);
        }

        public static SDL_PowerState SDL_GetJoystickPowerInfo(SDL_Joystick* joystick, out int percent)
        {
            fixed (int* ptr1 = &percent)
            {
                return iSDL_GetJoystickPowerInfo(joystick, ptr1);
            }
        }
    }
}