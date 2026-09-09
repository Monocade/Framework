using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVulkanOptions
    {
        private uint vulkan_api_version;

        private IntPtr feature_list;

        private IntPtr vulkan_10_physical_device_features;

        private uint device_extension_count;

        private byte** device_extension_names;

        private uint instance_extension_count;

        private byte** instance_extension_names;
    }
}