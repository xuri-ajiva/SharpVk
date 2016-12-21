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
    /// <para>
    /// Structure specifying specialization info.
    /// </para>
    /// <para>
    /// pname:pMapEntries points to a structure of type
    /// slink:VkSpecializationMapEntry.
    /// </para>
    /// </summary>
    public struct SpecializationInfo
    {
        /// <summary>
        /// pname:pMapEntries is a pointer to an array of
        /// sname:VkSpecializationMapEntry which maps constant IDs to offsets
        /// in pname:pData.
        /// </summary>
        public SpecializationMapEntry[] MapEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pData contains the actual constant values to specialize with.
        /// </summary>
        public byte[] Data
        {
            get;
            set;
        }
        
        internal unsafe Interop.SpecializationInfo* MarshalTo()
        {
            var result = (Interop.SpecializationInfo*)Interop.HeapUtil.AllocateAndClear<Interop.SpecializationInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.SpecializationInfo* pointer)
        {
            
            //MapEntries
            if (this.MapEntries != null)
            {
                pointer->MapEntries = (SpecializationMapEntry*)Interop.HeapUtil.Allocate<SpecializationMapEntry>(this.MapEntries.Length).ToPointer();
                for (int index = 0; index < this.MapEntries.Length; index++)
                {
                    pointer->MapEntries[index] = this.MapEntries[index];
                }
            }
            else
            {
                pointer->MapEntries = null;
            }
            pointer->Data = this.Data == null ? null : Interop.HeapUtil.MarshalTo(this.Data);
            pointer->MapEntryCount = (uint)(this.MapEntries?.Length ?? 0);
            pointer->DataSize = (Size)(this.Data?.Length ?? 0);
        }
    }
}
