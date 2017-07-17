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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// Structure specifying parameters for the generation of commands.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CommandProcessCommandsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectTable ObjectTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsToken[] IndirectCommandsTokens
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
        public SharpVk.CommandBuffer TargetCommandBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer SequencesCountBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize? SequencesCountOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer SequencesIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize? SequencesIndexOffset
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Experimental.CommandProcessCommandsInfo* pointer)
        {
            pointer->SType = StructureType.CommandProcessCommandsInfoNvx;
            pointer->Next = null;
            pointer->ObjectTable = this.ObjectTable?.handle ?? default(SharpVk.Interop.NVidia.Experimental.ObjectTable);
            pointer->IndirectCommandsLayout = this.IndirectCommandsLayout?.handle ?? default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout);
            pointer->IndirectCommandsTokenCount = (uint)(this.IndirectCommandsTokens?.Length ?? 0);
            if (this.IndirectCommandsTokens != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken>(this.IndirectCommandsTokens.Length).ToPointer());
                for(int index = 0; index < (uint)(this.IndirectCommandsTokens.Length); index++)
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
            pointer->TargetCommandBuffer = this.TargetCommandBuffer?.handle ?? default(SharpVk.Interop.CommandBuffer);
            pointer->SequencesCountBuffer = this.SequencesCountBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            if (this.SequencesCountOffset != null)
            {
                pointer->SequencesCountOffset = this.SequencesCountOffset.Value;
            }
            else
            {
                pointer->SequencesCountOffset = default(DeviceSize);
            }
            pointer->SequencesIndexBuffer = this.SequencesIndexBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            if (this.SequencesIndexOffset != null)
            {
                pointer->SequencesIndexOffset = this.SequencesIndexOffset.Value;
            }
            else
            {
                pointer->SequencesIndexOffset = default(DeviceSize);
            }
        }
    }
}
