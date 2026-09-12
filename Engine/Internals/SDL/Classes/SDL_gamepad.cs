using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_AddGamepadMapping(string mapping)
        {
            fixed (byte* ptr1 = SDL_StringToNative(mapping))
            {
                return iSDL_AddGamepadMapping(ptr1);
            }
        }

        public static int SDL_AddGamepadMappingsFromIO(SDL_IOStream* src, bool closeio)
        {
            return iSDL_AddGamepadMappingsFromIO(src, closeio);
        }

        public static int SDL_AddGamepadMappingsFromFile(string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_AddGamepadMappingsFromFile(ptr1);
            }
        }

        public static bool SDL_ReloadGamepadMappings()
        {
            return iSDL_ReloadGamepadMappings();
        }

        public static string[] SDL_GetGamepadMappings(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetGamepadMappings(&size), size, out count);
            }
        }

        public static string SDL_GetGamepadMappingForGUID(SDL_GUID guid)
        {
            return SDL_NativeToString(iSDL_GetGamepadMappingForGUID(guid), free: true);
        }

        public static string SDL_GetGamepadMapping(SDL_Gamepad* gamepad)
        {
            return SDL_NativeToString(iSDL_GetGamepadMapping(gamepad), free: true);
        }

        public static bool SDL_SetGamepadMapping(uint gamepadID, string mapping)
        {
            fixed (byte* ptr1 = SDL_StringToNative(mapping))
            {
                return iSDL_SetGamepadMapping(gamepadID, ptr1);
            }
        }

        public static bool SDL_HasGamepad()
        {
            return iSDL_HasGamepad();
        }

        public static uint[] SDL_GetGamepads(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetGamepads(&size), size, out count);
            }
        }

        public static bool SDL_IsGamepad(uint gamepadID)
        {
            return iSDL_IsGamepad(gamepadID);
        }

        public static string SDL_GetGamepadNameForID(uint gamepadID)
        {
            return SDL_NativeToString(iSDL_GetGamepadNameForID(gamepadID));
        }

        public static string SDL_GetGamepadPathForID(uint gamepadID)
        {
            return SDL_NativeToString(iSDL_GetGamepadPathForID(gamepadID));
        }

        public static int SDL_GetGamepadPlayerIndexForID(uint gamepadID)
        {
            return iSDL_GetGamepadPlayerIndexForID(gamepadID);
        }

        public static SDL_GUID SDL_GetGamepadGUIDForID(uint gamepadID)
        {
            return iSDL_GetGamepadGUIDForID(gamepadID);
        }

        public static ushort SDL_GetGamepadVendorForID(uint gamepadID)
        {
            return iSDL_GetGamepadVendorForID(gamepadID);
        }

        public static ushort SDL_GetGamepadProductForID(uint gamepadID)
        {
            return iSDL_GetGamepadProductForID(gamepadID);
        }

        public static ushort SDL_GetGamepadProductVersionForID(uint gamepadID)
        {
            return iSDL_GetGamepadProductVersionForID(gamepadID);
        }

        public static SDL_GamepadType SDL_GetGamepadTypeForID(uint gamepadID)
        {
            return iSDL_GetGamepadTypeForID(gamepadID);
        }

        public static SDL_GamepadType SDL_GetRealGamepadTypeForID(uint gamepadID)
        {
            return iSDL_GetRealGamepadTypeForID(gamepadID);
        }

        public static string SDL_GetGamepadMappingForID(uint gamepadID)
        {
            return SDL_NativeToString(iSDL_GetGamepadMappingForID(gamepadID), free: true);
        }

        public static SDL_Gamepad* SDL_OpenGamepad(uint gamepadID)
        {
            return iSDL_OpenGamepad(gamepadID);
        }

        public static SDL_Gamepad* SDL_GetGamepadFromID(uint gamepadID)
        {
            return iSDL_GetGamepadFromID(gamepadID);
        }

        public static SDL_Gamepad* SDL_GetGamepadFromPlayerIndex(int playerIndex)
        {
            return iSDL_GetGamepadFromPlayerIndex(playerIndex);
        }

        public static uint SDL_GetGamepadProperties(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadProperties(gamepad);
        }

        public static uint SDL_GetGamepadID(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadID(gamepad);
        }

        public static string SDL_GetGamepadName(SDL_Gamepad* gamepad)
        {
            return SDL_NativeToString(iSDL_GetGamepadName(gamepad));
        }

        public static string SDL_GetGamepadPath(SDL_Gamepad* gamepad)
        {
            return SDL_NativeToString(iSDL_GetGamepadPath(gamepad));
        }

        public static SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadType(gamepad);
        }

        public static SDL_GamepadType SDL_GetRealGamepadType(SDL_Gamepad* gamepad)
        {
            return iSDL_GetRealGamepadType(gamepad);
        }

        public static int SDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadPlayerIndex(gamepad);
        }

        public static bool SDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int playerIndex)
        {
            return iSDL_SetGamepadPlayerIndex(gamepad, playerIndex);
        }

        public static ushort SDL_GetGamepadVendor(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadVendor(gamepad);
        }

        public static ushort SDL_GetGamepadProduct(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadProduct(gamepad);
        }

        public static ushort SDL_GetGamepadProductVersion(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadProductVersion(gamepad);
        }

        public static ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadFirmwareVersion(gamepad);
        }

        public static string SDL_GetGamepadSerial(SDL_Gamepad* gamepad)
        {
            return SDL_NativeToString(iSDL_GetGamepadSerial(gamepad));
        }

        public static ulong SDL_GetGamepadSteamHandle(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadSteamHandle(gamepad);
        }

        public static SDL_JoystickConnectionState SDL_GetGamepadConnectionState(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadConnectionState(gamepad);
        }

        public static SDL_PowerState SDL_GetGamepadPowerInfo(SDL_Gamepad* gamepad, out int percent)
        {
            fixed (int* ptr1 = &percent)
            {
                return iSDL_GetGamepadPowerInfo(gamepad, ptr1);
            }
        }

        public static bool SDL_GamepadConnected(SDL_Gamepad* gamepad)
        {
            return iSDL_GamepadConnected(gamepad);
        }

        public static SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadJoystick(gamepad);
        }

        public static void SDL_SetGamepadEventsEnabled(bool enabled)
        {
            iSDL_SetGamepadEventsEnabled(enabled);
        }

        public static bool SDL_GamepadEventsEnabled()
        {
            return iSDL_GamepadEventsEnabled();
        }

        public static SDL_GamepadBinding*[] SDL_GetGamepadBindings(SDL_Gamepad* gamepad, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetGamepadBindings(gamepad, &size), size, out count);
            }
        }

        public static void SDL_UpdateGamepads()
        {
            iSDL_UpdateGamepads();
        }

        public static SDL_GamepadType SDL_GetGamepadTypeFromString(string str)
        {
            fixed (byte* ptr1 = SDL_StringToNative(str))
            {
                return iSDL_GetGamepadTypeFromString(ptr1);
            }
        }

        public static string SDL_GetGamepadStringForType(SDL_GamepadType type)
        {
            return SDL_NativeToString(iSDL_GetGamepadStringForType(type));
        }

        public static SDL_GamepadAxis SDL_GetGamepadAxisFromString(string str)
        {
            fixed (byte* ptr1 = SDL_StringToNative(str))
            {
                return iSDL_GetGamepadAxisFromString(ptr1);
            }
        }

        public static string SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis)
        {
            return SDL_NativeToString(iSDL_GetGamepadStringForAxis(axis));
        }

        public static bool SDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
        {
            return iSDL_GamepadHasAxis(gamepad, axis);
        }

        public static short SDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
        {
            return iSDL_GetGamepadAxis(gamepad, axis);
        }

        public static SDL_GamepadButton SDL_GetGamepadButtonFromString(string str)
        {
            fixed (byte* ptr1 = SDL_StringToNative(str))
            {
                return iSDL_GetGamepadButtonFromString(ptr1);
            }
        }

        public static string SDL_GetGamepadStringForButton(SDL_GamepadButton button)
        {
            return SDL_NativeToString(iSDL_GetGamepadStringForButton(button));
        }

        public static bool SDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GamepadHasButton(gamepad, button);
        }

        public static bool SDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadButton(gamepad, button);
        }

        public static SDL_GamepadButtonLabel SDL_GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadButtonLabelForType(type, button);
        }

        public static SDL_GamepadButtonLabel SDL_GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadButtonLabel(gamepad, button);
        }

        public static int SDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad)
        {
            return iSDL_GetNumGamepadTouchpads(gamepad);
        }

        public static int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad)
        {
            return iSDL_GetNumGamepadTouchpadFingers(gamepad, touchpad);
        }

        public static bool SDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, out bool down, out float x, out float y, out float pressure)
        {
            SDL_Bool ptr1 = default;
            
            fixed (float* ptr2 = &x)
            fixed (float* ptr3 = &y)
            fixed (float* ptr4 = &pressure)
            {
                var result = iSDL_GetGamepadTouchpadFinger(gamepad, touchpad, finger, &ptr1, ptr2, ptr3, ptr4);
                down = ptr1;
                
                return result;
            }
        }

        public static bool SDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type)
        {
            return iSDL_GamepadHasSensor(gamepad, type);
        }

        public static bool SDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, bool enabled)
        {
            return iSDL_SetGamepadSensorEnabled(gamepad, type, enabled);
        }

        public static bool SDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type)
        {
            return iSDL_GamepadSensorEnabled(gamepad, type);
        }

        public static float SDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type)
        {
            return iSDL_GetGamepadSensorDataRate(gamepad, type);
        }

        public static bool SDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, out float[] data, int numValues)
        {
            data = new float[numValues];
            {
                fixed (float* ptr1 = data)
                {
                    return iSDL_GetGamepadSensorData(gamepad, type, ptr1, numValues);
                }
            }
        }

        public static bool SDL_GamepadHasCapSense(SDL_Gamepad* gamepad, SDL_GamepadCapSenseType type)
        {
            return iSDL_GamepadHasCapSense(gamepad, type);
        }

        public static bool SDL_GetGamepadCapSense(SDL_Gamepad* gamepad, SDL_GamepadCapSenseType type)
        {
            return iSDL_GetGamepadCapSense(gamepad, type);
        }

        public static bool SDL_RumbleGamepad(SDL_Gamepad* gamepad, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs)
        {
            return iSDL_RumbleGamepad(gamepad, lowFrequencyRumble, highFrequencyRumble, durationMs);
        }

        public static bool SDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, ushort leftRumble, ushort rightRumble, uint durationMs)
        {
            return iSDL_RumbleGamepadTriggers(gamepad, leftRumble, rightRumble, durationMs);
        }

        public static bool SDL_SetGamepadLED(SDL_Gamepad* gamepad, byte red, byte green, byte blue)
        {
            return iSDL_SetGamepadLED(gamepad, red, green, blue);
        }

        public static bool SDL_SendGamepadEffect(SDL_Gamepad* gamepad, IntPtr data, int size)
        {
            return iSDL_SendGamepadEffect(gamepad, data, size);
        }

        public static void SDL_CloseGamepad(SDL_Gamepad* gamepad)
        {
            iSDL_CloseGamepad(gamepad);
        }

        public static string SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return SDL_NativeToString(iSDL_GetGamepadAppleSFSymbolsNameForButton(gamepad, button));
        }

        public static string SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
        {
            return SDL_NativeToString(iSDL_GetGamepadAppleSFSymbolsNameForAxis(gamepad, axis));
        }
    }
}