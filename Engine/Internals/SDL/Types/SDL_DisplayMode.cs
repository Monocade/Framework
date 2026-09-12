using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_DisplayMode
    {
        public uint DisplayID
        {
            get => displayID;
            set => displayID = value;
        }

        public SDL_PixelFormat Format
        {
            get => format;
            set => format = value;
        }

        public int W
        {
            get => w;
            set => w = value;
        }

        public int H
        {
            get => h;
            set => h = value;
        }

        public float PixelDensity
        {
            get => pixel_density;
            set => pixel_density = value;
        }

        public float RefreshRate
        {
            get => refresh_rate;
            set => refresh_rate = value;
        }

        public int RefreshRateNumerator
        {
            get => refresh_rate_numerator;
            set => refresh_rate_numerator = value;
        }

        public int RefreshRateDenominator
        {
            get => refresh_rate_denominator;
            set => refresh_rate_denominator = value;
        }

        public SDL_DisplayModeData* @Internal
        {
            get => @internal;
            set => @internal = value;
        }
    }
}