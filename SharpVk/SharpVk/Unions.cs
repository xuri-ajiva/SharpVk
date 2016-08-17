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
	[StructLayout(LayoutKind.Explicit)]
	public struct ClearColorValue
	{
		[FieldOffset(0)]
		public vec4 Float32;

        public static implicit operator ClearColorValue(vec4 value)
        {
            return new ClearColorValue
            {
                Float32 = value
            };
        }

		[FieldOffset(0)]
		public ivec4 Int32;

        public static implicit operator ClearColorValue(ivec4 value)
        {
            return new ClearColorValue
            {
                Int32 = value
            };
        }

		[FieldOffset(0)]
		public uvec4 Uint32;

        public static implicit operator ClearColorValue(uvec4 value)
        {
            return new ClearColorValue
            {
                Uint32 = value
            };
        }

	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ClearValue
	{
		[FieldOffset(0)]
		public ClearColorValue Color;

        public static implicit operator ClearValue(ClearColorValue value)
        {
            return new ClearValue
            {
                Color = value
            };
        }

		[FieldOffset(0)]
		public ClearDepthStencilValue DepthStencil;

        public static implicit operator ClearValue(ClearDepthStencilValue value)
        {
            return new ClearValue
            {
                DepthStencil = value
            };
        }

	}

}