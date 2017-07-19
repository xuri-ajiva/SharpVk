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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// Queue an image for presentation.
        /// </summary>
        public static unsafe void Present(this SharpVk.Queue extendedHandle, SharpVk.Semaphore[] waitSemaphores, SharpVk.Khronos.Swapchain[] swapchains, uint[] imageIndices, SharpVk.Result[] results)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PresentInfo* marshalledPresentInfo = default(SharpVk.Interop.Khronos.PresentInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledPresentInfo = (SharpVk.Interop.Khronos.PresentInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PresentInfo>());
                marshalledPresentInfo->SType = StructureType.PresentInfoKhr;
                marshalledPresentInfo->Next = null;
                marshalledPresentInfo->WaitSemaphoreCount = (uint)(waitSemaphores?.Length ?? 0);
                if (waitSemaphores != null)
                {
                    var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(waitSemaphores.Length).ToPointer());
                    for(int index = 0; index < (uint)(waitSemaphores.Length); index++)
                    {
                        fieldPointer[index] = waitSemaphores[index]?.handle ?? default(SharpVk.Interop.Semaphore);
                    }
                    marshalledPresentInfo->WaitSemaphores = fieldPointer;
                }
                else
                {
                    marshalledPresentInfo->WaitSemaphores = null;
                }
                marshalledPresentInfo->SwapchainCount = (uint)(swapchains?.Length ?? 0);
                if (swapchains != null)
                {
                    var fieldPointer = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Swapchain>(swapchains.Length).ToPointer());
                    for(int index = 0; index < (uint)(swapchains.Length); index++)
                    {
                        fieldPointer[index] = swapchains[index]?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                    }
                    marshalledPresentInfo->Swapchains = fieldPointer;
                }
                else
                {
                    marshalledPresentInfo->Swapchains = null;
                }
                if (imageIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(imageIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(imageIndices.Length); index++)
                    {
                        fieldPointer[index] = imageIndices[index];
                    }
                    marshalledPresentInfo->ImageIndices = fieldPointer;
                }
                else
                {
                    marshalledPresentInfo->ImageIndices = null;
                }
                if (results != null)
                {
                    var fieldPointer = (SharpVk.Result*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Result>(results.Length).ToPointer());
                    for(int index = 0; index < (uint)(results.Length); index++)
                    {
                        fieldPointer[index] = results[index];
                    }
                    marshalledPresentInfo->Results = fieldPointer;
                }
                else
                {
                    marshalledPresentInfo->Results = null;
                }
                SharpVk.Interop.Khronos.VkQueuePresentDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkQueuePresentDelegate>("vkQueuePresentKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPresentInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
