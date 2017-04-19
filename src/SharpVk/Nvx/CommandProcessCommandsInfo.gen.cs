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

namespace SharpVk.Nvx
{
    /// <summary>
    /// 
    /// </summary>
    public struct CommandProcessCommandsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public Nvx.ObjectTable ObjectTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Nvx.IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Nvx.IndirectCommandsToken[] IndirectCommandsTokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSequencesCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBuffer TargetCommandBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer SequencesCountBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SequencesCountOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer SequencesIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SequencesIndexOffset
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.Nvx.CommandProcessCommandsInfo* pointer)
        {
            pointer->SType = StructureType.CommandProcessCommandsInfoNvx;
            pointer->Next = null;
            pointer->ObjectTable = this.ObjectTable.handle;
            pointer->IndirectCommandsLayout = this.IndirectCommandsLayout.handle;
            pointer->IndirectCommandsTokenCount = (uint)this.IndirectCommandsTokens.Length;
            if (this.IndirectCommandsTokens != null)
            {
                var fieldPointer = (Interop.Nvx.IndirectCommandsToken*)Interop.HeapUtil.AllocateAndClear<Interop.Nvx.IndirectCommandsToken>(this.IndirectCommandsTokens.Length).ToPointer();
                for(int index = 0; index < this.IndirectCommandsTokens.Length; index++)
                {
                    this.IndirectCommandsTokens[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->IndirectCommandsTokens = fieldPointer;
            }
            else
            {
                pointer->IndirectCommandsTokens = null;
            }
            pointer->MaxSequencesCount = this.MaxSequencesCount;
            pointer->TargetCommandBuffer = this.TargetCommandBuffer.handle;
            pointer->SequencesCountBuffer = this.SequencesCountBuffer.handle;
            pointer->SequencesCountOffset = this.SequencesCountOffset;
            pointer->SequencesIndexBuffer = this.SequencesIndexBuffer.handle;
            pointer->SequencesIndexOffset = this.SequencesIndexOffset;
        }
    }
}
