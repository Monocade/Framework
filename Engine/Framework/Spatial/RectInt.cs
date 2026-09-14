using System;

namespace Engine
{
    public struct RectInt
    {
        public int X;
        public int Y;
        public int W;
        public int H;

        public RectInt(int x, int y, int w, int h)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
        }
    }
}