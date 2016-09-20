﻿//The MIT License (MIT)
//
//Copyright (c) Andrew Armstrong/FacticiusVir 2016
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
	/// <para>
    /// Structure specifying a clear color value.
	/// </para>
	/// <para>
    /// The four array elements of the clear color map to R, G, B, and A components of image formats, in order.
	/// </para>
	/// <para>
    /// If the image has more than one sample, the same value is written to all samples for any pixels being cleared.
	/// </para>
    /// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe partial struct ClearColorValue
	{
		[FieldOffset(0)]
		private fixed float float32[4];
		
		/// <summary>
		/// Implicit conversion of float[] to ClearColorValue.
		/// </summary>
        /// <param name="float32">
		/// <para>
		/// pname:float32 are the color clear values when the format of the image or attachment is floating point, unorm, snorm, uscaled, packed float, or sRGB. Floating point values are automatically converted to the format of the image, with the clear value being treated as linear if the image is sRGB.
		/// </para>
        /// </param>
        public static implicit operator ClearColorValue(float[] float32)
        {
            var result = new ClearColorValue();

            MemUtil.WriteToPtr(new IntPtr(result.float32), float32, 0, 4);

            return result;
        }

		[FieldOffset(0)]
		private fixed int int32[4];
		
		/// <summary>
		/// Implicit conversion of int[] to ClearColorValue.
		/// </summary>
        /// <param name="int32">
		/// <para>
		/// pname:int32 are the color clear values when the format of the image or attachment is signed integer. Signed integer values are converted to the format of the image by casting to the smaller type (with negative 32-bit values mapping to negative values in the smaller type). If the integer clear value is not representable in the target type (e.g. would overflow in conversion to that type), the clear value is undefined.
		/// </para>
        /// </param>
        public static implicit operator ClearColorValue(int[] int32)
        {
            var result = new ClearColorValue();

            MemUtil.WriteToPtr(new IntPtr(result.int32), int32, 0, 4);

            return result;
        }

		[FieldOffset(0)]
		private fixed uint uInt32[4];
		
		/// <summary>
		/// Implicit conversion of uint[] to ClearColorValue.
		/// </summary>
        /// <param name="uInt32">
		/// <para>
		/// pname:uint32 are the color clear values when the format of the image or attachment is unsigned integer. Unsigned integer values are converted to the format of the image by casting to the integer type with fewer bits.
		/// </para>
        /// </param>
        public static implicit operator ClearColorValue(uint[] uInt32)
        {
            var result = new ClearColorValue();

            MemUtil.WriteToPtr(new IntPtr(result.uInt32), uInt32, 0, 4);

            return result;
        }

	}

    /// <summary>
	/// <para>
    /// Structure specifying a clear value.
	/// </para>
	/// <para>
    /// This union is used where part of the API requires either color or depth/stencil clear values, depending on the attachment, and defines the initial clear values in the slink:VkRenderPassBeginInfo structure.
	/// </para>
    /// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe partial struct ClearValue
	{
		[FieldOffset(0)]
		private ClearColorValue color;
		
		/// <summary>
		/// Implicit converion of ClearColorValue to ClearValue.
		/// </summary>
        public static implicit operator ClearValue(ClearColorValue value)
        {
            return new ClearValue
            {
                color = value
            };
        }

		[FieldOffset(0)]
		private ClearDepthStencilValue depthStencil;
		
		/// <summary>
		/// Implicit converion of ClearDepthStencilValue to ClearValue.
		/// </summary>
        public static implicit operator ClearValue(ClearDepthStencilValue value)
        {
            return new ClearValue
            {
                depthStencil = value
            };
        }

	}

}