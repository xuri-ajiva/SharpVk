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
    /// Structure specifying parameters of a newly created descriptor update
    /// template.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorUpdateTemplateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateEntry[] DescriptorUpdateEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateType TemplateType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DescriptorSetLayout DescriptorSetLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineBindPoint? PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineLayout PipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint? Set
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo* pointer)
        {
            pointer->SType = StructureType.DescriptorUpdateTemplateCreateInfoKhr;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags);
            }
            pointer->DescriptorUpdateEntryCount = (uint)(this.DescriptorUpdateEntries?.Length ?? 0);
            if (this.DescriptorUpdateEntries != null)
            {
                var fieldPointer = (SharpVk.Khronos.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.DescriptorUpdateTemplateEntry>(this.DescriptorUpdateEntries.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DescriptorUpdateEntries.Length); index++)
                {
                    fieldPointer[index] = this.DescriptorUpdateEntries[index];
                }
                pointer->DescriptorUpdateEntries = fieldPointer;
            }
            else
            {
                pointer->DescriptorUpdateEntries = null;
            }
            pointer->TemplateType = this.TemplateType;
            pointer->DescriptorSetLayout = this.DescriptorSetLayout?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
            if (this.PipelineBindPoint != null)
            {
                pointer->PipelineBindPoint = this.PipelineBindPoint.Value;
            }
            else
            {
                pointer->PipelineBindPoint = default(SharpVk.PipelineBindPoint);
            }
            pointer->PipelineLayout = this.PipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            if (this.Set != null)
            {
                pointer->Set = this.Set.Value;
            }
            else
            {
                pointer->Set = default(uint);
            }
        }
    }
}
