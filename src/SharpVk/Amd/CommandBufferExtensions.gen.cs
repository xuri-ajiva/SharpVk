// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

namespace SharpVk.Amd
{
    /// <summary>
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Execute a pipelined write of a marker value into a buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="pipelineStage">
        /// One of the PipelineStageFlags values, specifying the pipeline stage
        /// whose completion triggers the marker write.
        /// </param>
        /// <param name="destinationBuffer">
        /// The buffer where the marker will be written to.
        /// </param>
        /// <param name="destinationOffset">
        /// The byte offset into the buffer where the marker will be written
        /// to.
        /// </param>
        /// <param name="marker">
        /// The 32-bit value of the marker.
        /// </param>
        public static unsafe void WriteBufferMarker(this CommandBuffer extendedHandle, PipelineStageFlags pipelineStage, Buffer destinationBuffer, ulong destinationOffset, uint marker)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferWriteBufferMarkerDelegate commandDelegate = commandCache.Cache.vkCmdWriteBufferMarkerAMD;
                commandDelegate(extendedHandle.Handle, pipelineStage, destinationBuffer?.Handle ?? default, destinationOffset, marker);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
