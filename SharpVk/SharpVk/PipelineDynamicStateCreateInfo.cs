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
    /// Structure specifying parameters of a newly created pipeline dynamic
    /// state.
    /// </summary>
    public struct PipelineDynamicStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineDynamicStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDynamicStates is an array of elink:VkDynamicState enums
        /// which indicate which pieces of pipeline state will use the values
        /// from dynamic state commands rather than from the pipeline state
        /// creation info.
        /// </summary>
        public DynamicState[] DynamicStates
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineDynamicStateCreateInfo Pack()
        {
            Interop.PipelineDynamicStateCreateInfo result = default(Interop.PipelineDynamicStateCreateInfo);
            return result;
        }
        
        internal unsafe Interop.PipelineDynamicStateCreateInfo* MarshalTo()
        {
            var result = (Interop.PipelineDynamicStateCreateInfo*)Interop.HeapUtil.Allocate<Interop.PipelineDynamicStateCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineDynamicStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineDynamicStateCreateInfo;
            
            //DynamicStates
            if (this.DynamicStates != null)
            {
                pointer->DynamicStates = (DynamicState*)Interop.HeapUtil.Allocate<int>(this.DynamicStates.Length).ToPointer();
                for (int index = 0; index < this.DynamicStates.Length; index++)
                {
                    pointer->DynamicStates[index] = this.DynamicStates[index];
                }
            }
            else
            {
                pointer->DynamicStates = null;
            }
            pointer->DynamicStateCount = (uint)(this.DynamicStates?.Length ?? 0);
            pointer->Flags = this.Flags;
        }
    }
}
