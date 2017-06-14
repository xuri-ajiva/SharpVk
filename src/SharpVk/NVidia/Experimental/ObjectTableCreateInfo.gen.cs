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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectTableCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryType[] ObjectEntryTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] ObjectEntryCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryUsageFlags[] ObjectEntryUsageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUniformBuffersPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStorageBuffersPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStorageImagesPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSampledImagesPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPipelineLayouts
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo* pointer)
        {
            pointer->SType = StructureType.ObjectTableCreateInfoNvx;
            pointer->Next = null;
            pointer->ObjectCount = (uint)(this.ObjectEntryTypes?.Length ?? 0);
            if (this.ObjectEntryTypes != null)
            {
                var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryType>(this.ObjectEntryTypes.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ObjectEntryTypes.Length); index++)
                {
                    fieldPointer[index] = this.ObjectEntryTypes[index];
                }
                pointer->ObjectEntryTypes = fieldPointer;
            }
            else
            {
                pointer->ObjectEntryTypes = null;
            }
            if (this.ObjectEntryCounts != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.ObjectEntryCounts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ObjectEntryCounts.Length); index++)
                {
                    fieldPointer[index] = this.ObjectEntryCounts[index];
                }
                pointer->ObjectEntryCounts = fieldPointer;
            }
            else
            {
                pointer->ObjectEntryCounts = null;
            }
            if (this.ObjectEntryUsageFlags != null)
            {
                var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryUsageFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryUsageFlags>(this.ObjectEntryUsageFlags.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ObjectEntryUsageFlags.Length); index++)
                {
                    fieldPointer[index] = this.ObjectEntryUsageFlags[index];
                }
                pointer->ObjectEntryUsageFlags = fieldPointer;
            }
            else
            {
                pointer->ObjectEntryUsageFlags = null;
            }
            pointer->MaxUniformBuffersPerDescriptor = this.MaxUniformBuffersPerDescriptor;
            pointer->MaxStorageBuffersPerDescriptor = this.MaxStorageBuffersPerDescriptor;
            pointer->MaxStorageImagesPerDescriptor = this.MaxStorageImagesPerDescriptor;
            pointer->MaxSampledImagesPerDescriptor = this.MaxSampledImagesPerDescriptor;
            pointer->MaxPipelineLayouts = this.MaxPipelineLayouts;
        }
    }
}
