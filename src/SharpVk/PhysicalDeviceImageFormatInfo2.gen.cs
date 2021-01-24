// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceImageFormatInfo2
    {
        /// <summary>
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ImageType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ImageCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PhysicalDeviceImageFormatInfo2* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceImageFormatInfo2Version;
            pointer->Next = null;
            pointer->Format = Format;
            pointer->Type = Type;
            pointer->Tiling = Tiling;
            pointer->Usage = Usage;
            if (Flags != null)
            {
                pointer->Flags = Flags.Value;
            }
            else
            {
                pointer->Flags = default;
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceImageFormatInfo2 MarshalFrom(SharpVk.Interop.PhysicalDeviceImageFormatInfo2* pointer)
        {
            PhysicalDeviceImageFormatInfo2 result = default;
            result.Format = pointer->Format;
            result.Type = pointer->Type;
            result.Tiling = pointer->Tiling;
            result.Usage = pointer->Usage;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}
