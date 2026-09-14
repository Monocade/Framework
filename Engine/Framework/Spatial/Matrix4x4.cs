using System;

namespace Engine
{
    public struct Matrix4x4
    {
        public float M11, M12, M13, M14;
        public float M21, M22, M23, M24;
        public float M31, M32, M33, M34;
        public float M41, M42, M43, M44;
        
        public Matrix4x4
        (
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44)
        {
            this.M11 = m11; this.M12 = m12; this.M13 = m13; this.M14 = m14;
            this.M21 = m21; this.M22 = m22; this.M23 = m23; this.M24 = m24;
            this.M31 = m31; this.M32 = m32; this.M33 = m33; this.M34 = m34;
            this.M41 = m41; this.M42 = m42; this.M43 = m43; this.M44 = m44;
        }
    }
}