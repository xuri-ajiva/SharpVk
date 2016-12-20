// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

namespace SharpVk
{
    /// <summary>
    /// Specify parameters of a command buffer marker region.
    /// </summary>
    public struct DebugMarkerMarkerInfo
    {
        /// <summary>
        /// pname:pMarkerName is a pointer to a null-terminated UTF-8 string
        /// that contains the name of the marker.
        /// </summary>
        public string MarkerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:color is an optional RGBA color value that can be associated
        /// with the marker. A particular implementation may: choose to ignore
        /// this color value. The values contain RGBA values in order, in the
        /// range 0.0 to 1.0. If all elements in pname:color are set to 0.0
        /// then it is ignored.
        /// </summary>
        public float[] Color
        {
            get;
            set;
        }
        
        internal unsafe Interop.DebugMarkerMarkerInfo Pack()
        {
            Interop.DebugMarkerMarkerInfo result = default(Interop.DebugMarkerMarkerInfo);
            return result;
        }
        
        internal unsafe Interop.DebugMarkerMarkerInfo* MarshalTo()
        {
            var result = (Interop.DebugMarkerMarkerInfo*)Interop.HeapUtil.Allocate<Interop.DebugMarkerMarkerInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DebugMarkerMarkerInfo* pointer)
        {
            pointer->SType = StructureType.DebugMarkerMarkerInfo;
            pointer->MarkerName = Interop.HeapUtil.MarshalTo(this.MarkerName);
            Validate.CheckLength(this.Color, 4, "Color");
            MemUtil.WriteToPtr((IntPtr)(pointer->Color), this.Color, 0, 4);
        }
    }
}
