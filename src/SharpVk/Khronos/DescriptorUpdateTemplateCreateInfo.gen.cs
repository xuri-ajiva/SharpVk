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
    public partial struct DescriptorUpdateTemplateCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of DescriptorUpdateTemplateEntryKHR structures describing
        /// the descriptors to be updated by the descriptor update template.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateEntry[] DescriptorUpdateEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// Specifies the type of the descriptor update template. If set to
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR it can only
        /// be used to update descriptor sets with a fixed descriptorSetLayout.
        /// If set to VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// it can only be used to push descriptor sets using the provided
        /// pipelineBindPoint, pipelineLayout, and set number.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateType TemplateType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The descriptor set layout the parameter update template will be
        /// used with. All descriptor sets which are going to be updated
        /// through the newly created descriptor update template must be
        /// created with this layout. descriptorSetLayout is the descriptor set
        /// layout used to build the descriptor update template. All descriptor
        /// sets which are going to be updated through the newly created
        /// descriptor update template must be created with a layout that
        /// matches (is the same as, or defined identically to) this layout.
        /// This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR.
        /// </summary>
        public SharpVk.DescriptorSetLayout DescriptorSetLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// A PipelineBindPoint indicating whether the descriptors will be used
        /// by graphics pipelines or compute pipelines. This parameter is
        /// ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </summary>
        public SharpVk.PipelineBindPoint? PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// A PipelineLayout object used to program the bindings. This
        /// parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </summary>
        public SharpVk.PipelineLayout PipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// The set number of the descriptor set in the pipeline layout that
        /// will be updated. This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR ifndef::VK_KHR_push_descriptor[]
        /// </summary>
        public uint? Set
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo* pointer)
        {
            pointer->SType = StructureType.DescriptorUpdateTemplateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags);
            }
            pointer->DescriptorUpdateEntryCount = (uint)(Interop.HeapUtil.GetLength(this.DescriptorUpdateEntries));
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
