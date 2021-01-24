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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        public static unsafe CheckpointData[] GetCheckpointData(this Queue extendedHandle)
        {
            try
            {
                CheckpointData[] result = default;
                uint marshalledCheckpointDataCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.CheckpointData* marshalledCheckpointData = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkQueueGetCheckpointDataDelegate commandDelegate = commandCache.Cache.vkGetQueueCheckpointDataNV;
                commandDelegate(extendedHandle.Handle, &marshalledCheckpointDataCount, marshalledCheckpointData);
                marshalledCheckpointData = (SharpVk.Interop.NVidia.CheckpointData*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CheckpointData>((uint)(marshalledCheckpointDataCount)));
                commandDelegate(extendedHandle.Handle, &marshalledCheckpointDataCount, marshalledCheckpointData);
                if (marshalledCheckpointData != null)
                {
                    var fieldPointer = new CheckpointData[(uint)(marshalledCheckpointDataCount)];
                    for(int index = 0; index < (uint)(marshalledCheckpointDataCount); index++)
                    {
                        fieldPointer[index] = CheckpointData.MarshalFrom(&marshalledCheckpointData[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
