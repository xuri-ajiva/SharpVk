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

namespace SharpVk.Khr
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorUpdateTemplateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khr.DescriptorUpdateTemplateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khr.DescriptorUpdateTemplateEntry[] DescriptorUpdateEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khr.DescriptorUpdateTemplateType TemplateType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetLayout DescriptorSetLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayout PipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Set
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.Khr.DescriptorUpdateTemplateCreateInfo* pointer)
        {
            pointer->SType = StructureType.DescriptorUpdateTemplateCreateInfoKhr;
            pointer->Next = null;
            pointer->Flags = this.Flags;
            pointer->DescriptorUpdateEntryCount = (uint)(this.DescriptorUpdateEntries?.Length ?? 0);
            if (this.DescriptorUpdateEntries != null)
            {
                var fieldPointer = (SharpVk.Khr.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khr.DescriptorUpdateTemplateEntry>(this.DescriptorUpdateEntries.Length).ToPointer());
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
            pointer->DescriptorSetLayout = this.DescriptorSetLayout.handle;
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->PipelineLayout = this.PipelineLayout.handle;
            pointer->Set = this.Set;
        }
    }
}
