using System;

namespace Engine
{
    public struct Rect
    {
        public float X;
        public float Y;
        public float W;
        public float H;

        public Rect(float x, float y, float w, float h)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
        }
    }
}