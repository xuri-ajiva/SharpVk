using System.Numerics;

namespace SharpVk
{
    public partial struct ClearColorValue
    {
		/// <summary>
        /// 
        /// </summary>
        public unsafe ClearColorValue(float r, float g, float b, float a)
        {
            fixed (float* floatArray = this.float32)
            {
                floatArray[0] = r;
                floatArray[1] = g;
                floatArray[2] = b;
                floatArray[3] = a;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public unsafe ClearColorValue(int r, int g, int b, int a)
        {
            fixed (int* intArray = this.int32)
            {
                intArray[0] = r;
                intArray[1] = g;
                intArray[2] = b;
                intArray[3] = a;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public unsafe ClearColorValue(uint r, uint g, uint b, uint a)
        {
            fixed (uint* uIntArray = this.uInt32)
            {
                uIntArray[0] = r;
                uIntArray[1] = g;
                uIntArray[2] = b;
                uIntArray[3] = a;
            }
        }

		/// <summary>
        /// 
        /// </summary>
		public static explicit operator ClearColorValue(Vector4 value)
        {
            return new ClearColorValue(value.X, value.Y, value.Z, value.W);
        }
    }
}
