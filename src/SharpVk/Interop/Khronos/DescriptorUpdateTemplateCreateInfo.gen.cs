// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2018
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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct DescriptorUpdateTemplateCreateInfo
    {
        /// <summary>
        /// The type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// Null or an extension-specific structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags Flags; 
        
        /// <summary>
        /// The number of elements in the pDescriptorUpdateEntries array.
        /// </summary>
        public uint DescriptorUpdateEntryCount; 
        
        /// <summary>
        /// An array of DescriptorUpdateTemplateEntryKHR structures describing
        /// the descriptors to be updated by the descriptor update template.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateEntry* DescriptorUpdateEntries; 
        
        /// <summary>
        /// Specifies the type of the descriptor update template. If set to
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR it can only
        /// be used to update descriptor sets with a fixed descriptorSetLayout.
        /// If set to VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// it can only be used to push descriptor sets using the provided
        /// pipelineBindPoint, pipelineLayout, and set number.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateType TemplateType; 
        
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
        public SharpVk.Interop.DescriptorSetLayout DescriptorSetLayout; 
        
        /// <summary>
        /// A PipelineBindPoint indicating whether the descriptors will be used
        /// by graphics pipelines or compute pipelines. This parameter is
        /// ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint; 
        
        /// <summary>
        /// A PipelineLayout object used to program the bindings. This
        /// parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </summary>
        public SharpVk.Interop.PipelineLayout PipelineLayout; 
        
        /// <summary>
        /// The set number of the descriptor set in the pipeline layout that
        /// will be updated. This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR ifndef::VK_KHR_push_descriptor[]
        /// </summary>
        public uint Set; 
    }
}
