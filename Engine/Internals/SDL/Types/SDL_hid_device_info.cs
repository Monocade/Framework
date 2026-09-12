using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_hid_device_info
    {
        public byte* Path
        {
            get => path;
            set => path = value;
        }

        public ushort VendorID
        {
            get => vendor_id;
            set => vendor_id = value;
        }

        public ushort ProductID
        {
            get => product_id;
            set => product_id = value;
        }

        public ushort* SerialNumber
        {
            get => serial_number;
            set => serial_number = value;
        }

        public ushort ReleaseNumber
        {
            get => release_number;
            set => release_number = value;
        }

        public ushort* ManufacturerString
        {
            get => manufacturer_string;
            set => manufacturer_string = value;
        }

        public ushort* ProductString
        {
            get => product_string;
            set => product_string = value;
        }

        public ushort UsagePage
        {
            get => usage_page;
            set => usage_page = value;
        }

        public ushort Usage
        {
            get => usage;
            set => usage = value;
        }

        public int InterfaceNumber
        {
            get => interface_number;
            set => interface_number = value;
        }

        public int InterfaceClass
        {
            get => interface_class;
            set => interface_class = value;
        }

        public int InterfaceSubclass
        {
            get => interface_subclass;
            set => interface_subclass = value;
        }

        public int InterfaceProtocol
        {
            get => interface_protocol;
            set => interface_protocol = value;
        }

        public SDL_hid_bus_type BusType
        {
            get => bus_type;
            set => bus_type = value;
        }

        public SDL_hid_device_info* Next
        {
            get => next;
            set => next = value;
        }
    }
}