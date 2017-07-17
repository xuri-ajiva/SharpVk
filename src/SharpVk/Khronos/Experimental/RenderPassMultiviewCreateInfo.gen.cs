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

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// Structure containing multiview info for all subpasses.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassMultiviewCreateInfo
    {
        /// <summary>
        /// An array of view masks, where each mask is a bitfield of view
        /// indices describing which views rendering is broadcast to in each
        /// subpass, when multiview is enabled. If subpassCount is zero, each
        /// view mask is treated as zero.
        /// </summary>
        public uint[] ViewMasks
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of dependencyCount view offsets, one for each dependency.
        /// If dependencyCount is zero, each dependency's view offset is
        /// treated as zero. Each view offset controls which views in the
        /// source subpass the views in the destination subpass depend on.
        /// </summary>
        public int[] ViewOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of view masks indicating sets of views that may be more
        /// efficient to render concurrently.
        /// </summary>
        public uint[] CorrelationMasks
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.Experimental.RenderPassMultiviewCreateInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassMultiviewCreateInfoKhx;
            pointer->Next = null;
            pointer->SubpassCount = (uint)(Interop.HeapUtil.GetLength(this.ViewMasks));
            if (this.ViewMasks != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.ViewMasks.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ViewMasks.Length); index++)
                {
                    fieldPointer[index] = this.ViewMasks[index];
                }
                pointer->ViewMasks = fieldPointer;
            }
            else
            {
                pointer->ViewMasks = null;
            }
            pointer->DependencyCount = (uint)(Interop.HeapUtil.GetLength(this.ViewOffsets));
            if (this.ViewOffsets != null)
            {
                var fieldPointer = (int*)(Interop.HeapUtil.AllocateAndClear<int>(this.ViewOffsets.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ViewOffsets.Length); index++)
                {
                    fieldPointer[index] = this.ViewOffsets[index];
                }
                pointer->ViewOffsets = fieldPointer;
            }
            else
            {
                pointer->ViewOffsets = null;
            }
            pointer->CorrelationMaskCount = (uint)(Interop.HeapUtil.GetLength(this.CorrelationMasks));
            if (this.CorrelationMasks != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.CorrelationMasks.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CorrelationMasks.Length); index++)
                {
                    fieldPointer[index] = this.CorrelationMasks[index];
                }
                pointer->CorrelationMasks = fieldPointer;
            }
            else
            {
                pointer->CorrelationMasks = null;
            }
        }
    }
}
