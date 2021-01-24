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
    public static class AccelerationStructureExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The AccelerationStructure handle to extend.
        /// </param>
        /// <param name="dataSize">
        /// </param>
        public static unsafe byte[] GetHandle(this Khronos.AccelerationStructure extendedHandle, HostSize dataSize)
        {
            try
            {
                byte[] result = default;
                CommandCache commandCache = default;
                HostSize marshalledDataSize = default;
                byte* marshalledData = default;
                commandCache = extendedHandle.commandCache;
                marshalledDataSize = dataSize;
                marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>(marshalledDataSize));
                SharpVk.Interop.NVidia.VkAccelerationStructureKHRGetHandleDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureHandleNV;
                Result methodResult = commandDelegate(extendedHandle.parent.Handle, extendedHandle.Handle, marshalledDataSize, marshalledData);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledData != null)
                {
                    var fieldPointer = new byte[(uint)(marshalledDataSize)];
                    for(int index = 0; index < (uint)(marshalledDataSize); index++)
                    {
                        fieldPointer[index] = marshalledData[index];
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
