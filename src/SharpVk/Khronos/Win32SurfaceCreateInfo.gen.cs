// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Khronos
{
    /// <summary>
    /// Structure specifying parameters of a newly created Win32 surface
    /// object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Win32SurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.Khronos.Win32SurfaceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:hinstance and pname:hwnd are the Win32 code:HINSTANCE and
        /// code:HWND for the window to associate the surface with.
        /// </summary>
        public IntPtr Hinstance
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Hwnd
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.Win32SurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.Win32SurfaceCreateInfoKhr;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.Win32SurfaceCreateFlags);
            }
            pointer->Hinstance = this.Hinstance;
            pointer->Hwnd = this.Hwnd;
        }
    }
}
