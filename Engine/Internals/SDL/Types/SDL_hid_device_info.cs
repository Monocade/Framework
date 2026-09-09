using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_hid_device_info
    {
        private byte* path;

        private ushort vendor_id;

        private ushort product_id;

        private ushort* serial_number;

        private ushort release_number;

        private ushort* manufacturer_string;

        private ushort* product_string;

        private ushort usage_page;

        private ushort usage;

        private int interface_number;

        private int interface_class;

        private int interface_subclass;

        private int interface_protocol;

        private SDL_hid_bus_type bus_type;

        private SDL_hid_device_info* next;
    }
}