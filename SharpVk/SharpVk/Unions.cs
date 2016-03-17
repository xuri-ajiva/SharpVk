//The MIT License (MIT)
//
//Copyright (c) 2016 Andrew Armstrong/FacticiusVir
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

using System.Runtime.InteropServices;

namespace SharpVk
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ClearColorValue
	{
		[FieldOffset(sizeof(float) * 0)]
		public float Float32_0;
		[FieldOffset(sizeof(float) * 1)]
		public float Float32_1;
		[FieldOffset(sizeof(float) * 2)]
		public float Float32_2;
		[FieldOffset(sizeof(float) * 3)]
		public float Float32_3;
		[FieldOffset(sizeof(int) * 0)]
		public int Int32_0;
		[FieldOffset(sizeof(int) * 1)]
		public int Int32_1;
		[FieldOffset(sizeof(int) * 2)]
		public int Int32_2;
		[FieldOffset(sizeof(int) * 3)]
		public int Int32_3;
		[FieldOffset(sizeof(uint) * 0)]
		public uint Uint32_0;
		[FieldOffset(sizeof(uint) * 1)]
		public uint Uint32_1;
		[FieldOffset(sizeof(uint) * 2)]
		public uint Uint32_2;
		[FieldOffset(sizeof(uint) * 3)]
		public uint Uint32_3;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ClearValue
	{
		[FieldOffset(0)]
		public ClearColorValue Color;
		[FieldOffset(0)]
		public Interop.ClearDepthStencilValue DepthStencil;
	}

}