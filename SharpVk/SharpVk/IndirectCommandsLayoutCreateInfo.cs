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
    /// Structure specifying the parameters of a newly created indirect
    /// commands layout object.
    /// </summary>
    public struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// pname:pipelineBindPoint is the sname:VkPipelineBindPoint that this
        /// layout targets.
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags is a bitmask providing usage hints of this layout. See
        /// elink:VkIndirectCommandsLayoutUsageFlagBitsNVX below for a
        /// description of the supported bits.
        /// </summary>
        public IndirectCommandsLayoutUsageFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTokens is an array describing each command token in detail.
        /// See elink:VkIndirectCommandsTokenTypeNVX and
        /// slink:VkIndirectCommandsLayoutTokenNVX below for details.
        /// </summary>
        public IndirectCommandsLayoutToken[] Tokens
        {
            get;
            set;
        }
        
        internal unsafe Interop.IndirectCommandsLayoutCreateInfo* MarshalTo()
        {
            var result = (Interop.IndirectCommandsLayoutCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.IndirectCommandsLayoutCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.IndirectCommandsLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.IndirectCommandsLayoutCreateInfoNvx;
            
            //Tokens
            if (this.Tokens != null)
            {
                pointer->Tokens = (IndirectCommandsLayoutToken*)Interop.HeapUtil.Allocate<IndirectCommandsLayoutToken>(this.Tokens.Length).ToPointer();
                for (int index = 0; index < this.Tokens.Length; index++)
                {
                    pointer->Tokens[index] = this.Tokens[index];
                }
            }
            else
            {
                pointer->Tokens = null;
            }
            pointer->TokenCount = (uint)(this.Tokens?.Length ?? 0);
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->Flags = this.Flags;
        }
    }
}
