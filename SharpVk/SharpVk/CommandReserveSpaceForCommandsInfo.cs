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
    /// Structure specifying parameters for the reservation of command buffer
    /// space.
    /// </summary>
    public struct CommandReserveSpaceForCommandsInfo
    {
        /// <summary>
        /// pname:objectTable is the sname:VkObjectTableNVX to be used for the
        /// generation process. Only registered objects at the time
        /// flink:vkCmdReserveSpaceForCommandsNVX is called, will be taken into
        /// account for the reservation.
        /// </summary>
        public ObjectTable ObjectTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:indirectCommandsLayout is the
        /// sname:VkIndirectCommandsLayoutNVX that must: also be used at
        /// generation time.
        /// </summary>
        public IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSequencesCount is the maximum number of sequences for
        /// which command buffer space will be reserved.
        /// </summary>
        public uint MaxSequencesCount
        {
            get;
            set;
        }
        
        internal unsafe Interop.CommandReserveSpaceForCommandsInfo* MarshalTo()
        {
            var result = (Interop.CommandReserveSpaceForCommandsInfo*)Interop.HeapUtil.AllocateAndClear<Interop.CommandReserveSpaceForCommandsInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.CommandReserveSpaceForCommandsInfo* pointer)
        {
            pointer->SType = StructureType.CommandReserveSpaceForCommandsInfoNvx;
            pointer->Next = null;
            this.ObjectTable?.MarshalTo(&pointer->ObjectTable);
            this.IndirectCommandsLayout?.MarshalTo(&pointer->IndirectCommandsLayout);
            pointer->MaxSequencesCount = this.MaxSequencesCount;
        }
    }
}
