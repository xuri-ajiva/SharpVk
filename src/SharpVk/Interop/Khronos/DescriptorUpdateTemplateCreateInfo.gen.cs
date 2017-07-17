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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorUpdateTemplateCreateInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags Flags; 
        
        /// <summary>
        /// pname:descriptorUpdateEntryCount is the number of elements in the
        /// pname:pDescriptorUpdateEntries array.
        /// </summary>
        public uint DescriptorUpdateEntryCount; 
        
        /// <summary>
        /// pname:pDescriptorUpdateEntries is a pointer to an array of
        /// slink:VkDescriptorUpdateTemplateEntryKHR structures describing the
        /// descriptors to be updated by the descriptor update template.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateEntry* DescriptorUpdateEntries; 
        
        /// <summary>
        /// pname:templateType Specifies the type of the descriptor update
        /// template. If set to
        /// ename:VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR it can:
        /// only be used to update descriptor sets with a fixed
        /// pname:descriptorSetLayout. If set to
        /// ename:VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR it
        /// can: only be used to push descriptor sets using the provided
        /// pname:pipelineBindPoint, pname:pipelineLayout, and pname:set
        /// number.
        /// </summary>
        public SharpVk.Khronos.DescriptorUpdateTemplateType TemplateType; 
        
        /// <summary>
        /// pname:descriptorSetLayout is the descriptor set layout the
        /// parameter update template will be used with. All descriptor sets
        /// which are going to be updated through the newly created descriptor
        /// update template must: be created with this layout.
        /// pname:descriptorSetLayout is the descriptor set layout used to
        /// build the descriptor update template. All descriptor sets which are
        /// going to be updated through the newly created descriptor update
        /// template must: be created with a layout that matches (is the same
        /// as, or defined identically to) this layout. This parameter is
        /// ignored if pname:templateType is not
        /// ename:VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR.
        /// </summary>
        public SharpVk.Interop.DescriptorSetLayout DescriptorSetLayout; 
        
        /// <summary>
        /// pname:pipelineBindPoint is a elink:VkPipelineBindPoint indicating
        /// whether the descriptors will be used by graphics pipelines or
        /// compute pipelines. This parameter is ignored if pname:templateType
        /// is not
        /// ename:VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint; 
        
        /// <summary>
        /// pname:pipelineLayout is a sname:VkPipelineLayout object used to
        /// program the bindings. This parameter is ignored if
        /// pname:templateType is not
        /// ename:VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </summary>
        public SharpVk.Interop.PipelineLayout PipelineLayout; 
        
        /// <summary>
        /// pname:set is the set number of the descriptor set in the pipeline
        /// layout that will be updated. This parameter is ignored if
        /// pname:templateType is not
        /// ename:VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR ifndef::VK_KHR_push_descriptor[]
        /// </summary>
        public uint Set; 
    }
}
