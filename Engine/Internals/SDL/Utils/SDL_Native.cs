using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static readonly NativeProvider NativeProvider = new SDLNativeProvider();
    }
}