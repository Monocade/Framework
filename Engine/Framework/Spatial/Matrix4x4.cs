using System;

namespace Engine
{
    public struct Matrix4x4
    {
        public float m11, m12, m13, m14;
        public float m21, m22, m23, m24;
        public float m31, m32, m33, m34;
        public float m41, m42, m43, m44;
        
        public Matrix4x4
        (
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44)
        {
            this.m11 = m11; this.m12 = m12; this.m13 = m13; this.m14 = m14;
            this.m21 = m21; this.m22 = m22; this.m23 = m23; this.m24 = m24;
            this.m31 = m31; this.m32 = m32; this.m33 = m33; this.m34 = m34;
            this.m41 = m41; this.m42 = m42; this.m43 = m43; this.m44 = m44;
        }
    }
}