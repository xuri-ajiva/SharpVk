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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying a descriptor set layout binding.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorSetLayoutBinding
    {
        /// <summary>
        /// pname:binding is the binding number of this entry and corresponds
        /// to a resource of the same binding number in the shader stages.
        /// </summary>
        public uint Binding
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorType is a elink:VkDescriptorType specifying which
        /// type of resource descriptors are used for this binding.
        /// </summary>
        public SharpVk.DescriptorType DescriptorType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorCount is the number of descriptors contained in the
        /// binding, accessed in a shader as an array. If pname:descriptorCount
        /// is zero this binding entry is reserved and the resource must: not
        /// be accessed from any stage via this binding within any pipeline
        /// using the set layout.
        /// </summary>
        public uint? DescriptorCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stageFlags member is a bitmask of elink:VkShaderStageFlagBits
        /// specifying which pipeline shader stages can: access a resource for
        /// this binding. ename:VK_SHADER_STAGE_ALL is a shorthand specifying
        /// that all defined shader stages, including any additional stages
        /// defined by extensions, can: access the resource. + -- If a shader
        /// stage is not included in pname:stageFlags, then a resource must:
        /// not be accessed from that stage via this binding within any
        /// pipeline using the set layout. There are no limitations on what
        /// combinations of stages can: be used by a descriptor binding, and in
        /// particular a binding can: be used by both graphics stages and the
        /// compute stage. --
        /// </summary>
        public SharpVk.ShaderStageFlags StageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImmutableSamplers affects initialization of samplers. If
        /// pname:descriptorType specifies a ename:VK_DESCRIPTOR_TYPE_SAMPLER
        /// or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER type descriptor,
        /// then pname:pImmutableSamplers can: be used to initialize a set of
        /// _immutable samplers_. Immutable samplers are permanently bound into
        /// the set layout; later binding a sampler into an immutable sampler
        /// slot in a descriptor set is not allowed. If
        /// pname:pImmutableSamplers is not `NULL`, then it is considered to be
        /// a pointer to an array of sampler handles that will be consumed by
        /// the set layout and used for the corresponding binding. If
        /// pname:pImmutableSamplers is `NULL`, then the sampler slots are
        /// dynamic and sampler handles must: be bound into descriptor sets
        /// using this layout. If pname:descriptorType is not one of these
        /// descriptor types, then pname:pImmutableSamplers is ignored.
        /// </summary>
        public SharpVk.Sampler[] ImmutableSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.DescriptorSetLayoutBinding* pointer)
        {
            pointer->Binding = this.Binding;
            pointer->DescriptorType = this.DescriptorType;
            if (this.DescriptorCount != null)
            {
                pointer->DescriptorCount = this.DescriptorCount.Value;
            }
            else
            {
                pointer->DescriptorCount = (uint)(this.ImmutableSamplers?.Length ?? 0);
            }
            pointer->StageFlags = this.StageFlags;
            if (this.ImmutableSamplers != null)
            {
                var fieldPointer = (SharpVk.Interop.Sampler*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Sampler>(this.ImmutableSamplers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImmutableSamplers.Length); index++)
                {
                    fieldPointer[index] = this.ImmutableSamplers[index]?.handle ?? default(SharpVk.Interop.Sampler);
                }
                pointer->ImmutableSamplers = fieldPointer;
            }
            else
            {
                pointer->ImmutableSamplers = null;
            }
        }
    }
}
