//The MIT License (MIT)
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

using GlmSharp;
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
	public struct ClearColorValue
	{
	   /// <summary>
		/// <para>
		/// pname:float32 are the color clear values when the format of the image or attachment is floating point, unorm, snorm, uscaled, packed float, or sRGB. Floating point values are automatically converted to the format of the image, with the clear value being treated as linear if the image is sRGB.
		/// </para>
		/// </summary>
		[FieldOffset(0)]
		public vec4 Float32;
		
		/// <summary>
		/// Implicit convertion of vec4 to ClearColorValue.
		/// </summary>
        public static implicit operator ClearColorValue(vec4 value)
        {
            return new ClearColorValue
            {
                Float32 = value
            };
        }

	   /// <summary>
		/// <para>
		/// pname:int32 are the color clear values when the format of the image or attachment is signed integer. Signed integer values are converted to the format of the image by casting to the smaller type (with negative 32-bit values mapping to negative values in the smaller type). If the integer clear value is not representable in the target type (e.g. would overflow in conversion to that type), the clear value is undefined.
		/// </para>
		/// </summary>
		[FieldOffset(0)]
		public ivec4 Int32;
		
		/// <summary>
		/// Implicit convertion of ivec4 to ClearColorValue.
		/// </summary>
        public static implicit operator ClearColorValue(ivec4 value)
        {
            return new ClearColorValue
            {
                Int32 = value
            };
        }

	   /// <summary>
		/// <para>
		/// pname:uint32 are the color clear values when the format of the image or attachment is unsigned integer. Unsigned integer values are converted to the format of the image by casting to the integer type with fewer bits.
		/// </para>
		/// </summary>
		[FieldOffset(0)]
		public uvec4 Uint32;
		
		/// <summary>
		/// Implicit convertion of uvec4 to ClearColorValue.
		/// </summary>
        public static implicit operator ClearColorValue(uvec4 value)
        {
            return new ClearColorValue
            {
                Uint32 = value
            };
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
	public struct ClearValue
	{
	   /// <summary>
		/// <para>
		/// pname:color specifies the color image clear values to use when clearing a color image or attachment.
		/// </para>
		/// </summary>
		[FieldOffset(0)]
		public ClearColorValue Color;
		
		/// <summary>
		/// Implicit convertion of ClearColorValue to ClearValue.
		/// </summary>
        public static implicit operator ClearValue(ClearColorValue value)
        {
            return new ClearValue
            {
                Color = value
            };
        }

	   /// <summary>
		/// <para>
		/// pname:depthStencil specifies the depth and stencil clear values to use when clearing a depth/stencil image or attachment.
		/// </para>
		/// </summary>
		[FieldOffset(0)]
		public ClearDepthStencilValue DepthStencil;
		
		/// <summary>
		/// Implicit convertion of ClearDepthStencilValue to ClearValue.
		/// </summary>
        public static implicit operator ClearValue(ClearDepthStencilValue value)
        {
            return new ClearValue
            {
                DepthStencil = value
            };
        }

	}

}