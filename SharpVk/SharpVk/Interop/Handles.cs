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

using System;

namespace SharpVk.Interop
{
	public struct Buffer
	{
		internal IntPtr handle;

		public static Buffer Null
		{
			get
			{
				return new Buffer
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Device
	{
		internal IntPtr handle;

		public static Device Null
		{
			get
			{
				return new Device
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Image
	{
		internal IntPtr handle;

		public static Image Null
		{
			get
			{
				return new Image
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Instance
	{
		internal IntPtr handle;

		public static Instance Null
		{
			get
			{
				return new Instance
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct PhysicalDevice
	{
		internal IntPtr handle;

		public static PhysicalDevice Null
		{
			get
			{
				return new PhysicalDevice
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

}