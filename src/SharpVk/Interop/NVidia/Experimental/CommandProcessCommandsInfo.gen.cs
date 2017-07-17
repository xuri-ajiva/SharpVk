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

namespace SharpVk.Interop.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CommandProcessCommandsInfo
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
        /// pname:objectTable is the sname:VkObjectTableNVX to be used for the
        /// generation process. Only registered objects at the time
        /// flink:vkCmdReserveSpaceForCommandsNVX is called, will be taken into
        /// account for the reservation.
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.ObjectTable ObjectTable; 
        
        /// <summary>
        /// pname:indirectCommandsLayout is the
        /// sname:VkIndirectCommandsLayoutNVX that provides the command
        /// sequence to generate.
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout IndirectCommandsLayout; 
        
        /// <summary>
        /// pname:indirectCommandsTokenCount defines the number of input tokens
        /// used.
        /// </summary>
        public uint IndirectCommandsTokenCount; 
        
        /// <summary>
        /// pname:pIndirectCommandsTokens provides an array of
        /// slink:VkIndirectCommandsTokenNVX that reference the input data for
        /// each token command.
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken* IndirectCommandsTokens; 
        
        /// <summary>
        /// pname:maxSequencesCount is the maximum number of sequences for
        /// which command buffer space will be reserved. If
        /// pname:sequencesCountBuffer is dlink:VK_NULL_HANDLE, this is also
        /// the actual number of sequences generated.
        /// </summary>
        public uint MaxSequencesCount; 
        
        /// <summary>
        /// pname:targetCommandBuffer can: be the secondary
        /// sname:VkCommandBuffer in which the commands should be recorded. If
        /// pname:targetCommandBuffer is `NULL` an implicit reservation as well
        /// as execution takes place on the processing sname:VkCommandBuffer.
        /// </summary>
        public SharpVk.Interop.CommandBuffer TargetCommandBuffer; 
        
        /// <summary>
        /// pname:sequencesCountBuffer can: be sname:VkBuffer from which the
        /// actual amount of sequences is sourced from as ftext:uint32_t value.
        /// </summary>
        public SharpVk.Interop.Buffer SequencesCountBuffer; 
        
        /// <summary>
        /// pname:sequencesCountOffset is the byte offset into
        /// pname:sequencesCountBuffer where the count value is stored.
        /// </summary>
        public DeviceSize SequencesCountOffset; 
        
        /// <summary>
        /// pname:sequencesIndexBuffer must: be set if
        /// pname:indirectCommandsLayout's ename:VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT
        /// is set and provides the used sequence indices as ftext:uint32_t
        /// array. Otherwise it must: be dlink:VK_NULL_HANDLE.
        /// </summary>
        public SharpVk.Interop.Buffer SequencesIndexBuffer; 
        
        /// <summary>
        /// pname:sequencesIndexOffset is the byte offset into
        /// pname:sequencesIndexBuffer where the index values start.
        /// </summary>
        public DeviceSize SequencesIndexOffset; 
    }
}
