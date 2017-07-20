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
    /// Structure specifying parameters of a newly created Mir surface object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MirSurfaceCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.Khronos.MirSurfaceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// connection and surface are pointers to the MirConnection and
        /// MirSurface for the window to associate the surface with.
        /// </summary>
        public IntPtr Connection
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr MirSurface
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.MirSurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.MirSurfaceCreateInfoKhr;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.MirSurfaceCreateFlags);
            }
            pointer->Connection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
            *pointer->Connection = this.Connection;
            pointer->MirSurface = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
            *pointer->MirSurface = this.MirSurface;
        }
    }
}
