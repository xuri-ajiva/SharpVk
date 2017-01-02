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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying parameters of a newly created pipeline vertex
    /// input state.
    /// </summary>
    public struct PipelineVertexInputStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineVertexInputStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexBindingDescriptions is a pointer to an array of
        /// sname:VkVertexInputBindingDescription structures.
        /// </summary>
        public VertexInputBindingDescription[] VertexBindingDescriptions
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexAttributeDescriptions is a pointer to an array of
        /// sname:VkVertexInputAttributeDescription structures.
        /// </summary>
        public VertexInputAttributeDescription[] VertexAttributeDescriptions
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineVertexInputStateCreateInfo* MarshalTo()
        {
            var result = (Interop.PipelineVertexInputStateCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.PipelineVertexInputStateCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineVertexInputStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineVertexInputStateCreateInfo;
            
            //VertexBindingDescriptions
            if (this.VertexBindingDescriptions != null)
            {
                pointer->VertexBindingDescriptions = (VertexInputBindingDescription*)Interop.HeapUtil.Allocate<VertexInputBindingDescription>(this.VertexBindingDescriptions.Length).ToPointer();
                for (int index = 0; index < this.VertexBindingDescriptions.Length; index++)
                {
                    pointer->VertexBindingDescriptions[index] = this.VertexBindingDescriptions[index];
                }
            }
            else
            {
                pointer->VertexBindingDescriptions = null;
            }
            
            //VertexAttributeDescriptions
            if (this.VertexAttributeDescriptions != null)
            {
                pointer->VertexAttributeDescriptions = (VertexInputAttributeDescription*)Interop.HeapUtil.Allocate<VertexInputAttributeDescription>(this.VertexAttributeDescriptions.Length).ToPointer();
                for (int index = 0; index < this.VertexAttributeDescriptions.Length; index++)
                {
                    pointer->VertexAttributeDescriptions[index] = this.VertexAttributeDescriptions[index];
                }
            }
            else
            {
                pointer->VertexAttributeDescriptions = null;
            }
            pointer->VertexBindingDescriptionCount = (uint)(this.VertexBindingDescriptions?.Length ?? 0);
            pointer->VertexAttributeDescriptionCount = (uint)(this.VertexAttributeDescriptions?.Length ?? 0);
            pointer->Flags = this.Flags;
        }
    }
}
