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
    /// -
    /// </summary>
    public struct CommandProcessCommandsInfo
    {
        /// <summary>
        /// -
        /// </summary>
        public ObjectTable ObjectTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IndirectCommandsToken[] IndirectCommandsTokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint MaxSequencesCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public CommandBuffer TargetCommandBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Buffer SequencesCountBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public ulong SequencesCountOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Buffer SequencesIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public ulong SequencesIndexOffset
        {
            get;
            set;
        }
        
        internal unsafe Interop.CommandProcessCommandsInfo Pack()
        {
            Interop.CommandProcessCommandsInfo result = default(Interop.CommandProcessCommandsInfo);
            result.SType = StructureType.CommandProcessCommandsInfoNvx;
            result.ObjectTable = this.ObjectTable?.Pack() ?? Interop.ObjectTable.Null;
            result.IndirectCommandsLayout = this.IndirectCommandsLayout?.Pack() ?? Interop.IndirectCommandsLayout.Null;
            
            //IndirectCommandsTokens
            if (this.IndirectCommandsTokens != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.IndirectCommandsToken>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.IndirectCommandsToken>(this.IndirectCommandsTokens.Length);
                for (int index = 0; index < this.IndirectCommandsTokens.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.IndirectCommandsTokens[index].Pack(), pointer + (size * index), false);
                }
                result.IndirectCommandsTokens = (Interop.IndirectCommandsToken*)pointer.ToPointer();
            }
            else
            {
                result.IndirectCommandsTokens = null;
            }
            result.TargetCommandBuffer = this.TargetCommandBuffer?.Pack() ?? Interop.CommandBuffer.Null;
            result.SequencesCountBuffer = this.SequencesCountBuffer?.Pack() ?? Interop.Buffer.Null;
            result.SequencesIndexBuffer = this.SequencesIndexBuffer?.Pack() ?? Interop.Buffer.Null;
            result.IndirectCommandsTokenCount = (uint)(this.IndirectCommandsTokens?.Length ?? 0);
            result.MaxSequencesCount = this.MaxSequencesCount;
            result.SequencesCountOffset = this.SequencesCountOffset;
            result.SequencesIndexOffset = this.SequencesIndexOffset;
            return result;
        }
        
        internal unsafe Interop.CommandProcessCommandsInfo* MarshalTo()
        {
            return (Interop.CommandProcessCommandsInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
