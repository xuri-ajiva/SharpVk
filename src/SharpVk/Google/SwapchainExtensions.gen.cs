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

namespace SharpVk.Google
{
    /// <summary>
    /// </summary>
    public static class SwapchainExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Swapchain handle to extend.
        /// </param>
        public static unsafe RefreshCycleDuration GetRefreshCycleDuration(this Khronos.Swapchain extendedHandle)
        {
            try
            {
                RefreshCycleDuration result = default;
                CommandCache commandCache = default;
                RefreshCycleDuration marshalledDisplayTimingProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Google.VkSwapchainKHRGetRefreshCycleDurationDelegate commandDelegate = commandCache.Cache.vkGetRefreshCycleDurationGOOGLE;
                Result methodResult = commandDelegate(extendedHandle.parent.Handle, extendedHandle.Handle, &marshalledDisplayTimingProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledDisplayTimingProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Swapchain handle to extend.
        /// </param>
        public static unsafe PastPresentationTiming[] GetPastPresentationTiming(this Khronos.Swapchain extendedHandle)
        {
            try
            {
                PastPresentationTiming[] result = default;
                uint marshalledPresentationTimingCount = default;
                CommandCache commandCache = default;
                PastPresentationTiming* marshalledPresentationTimings = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Google.VkSwapchainKHRGetPastPresentationTimingDelegate commandDelegate = commandCache.Cache.vkGetPastPresentationTimingGOOGLE;
                Result methodResult = commandDelegate(extendedHandle.parent.Handle, extendedHandle.Handle, &marshalledPresentationTimingCount, marshalledPresentationTimings);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPresentationTimings = (PastPresentationTiming*)(Interop.HeapUtil.Allocate<PastPresentationTiming>((uint)(marshalledPresentationTimingCount)));
                commandDelegate(extendedHandle.parent.Handle, extendedHandle.Handle, &marshalledPresentationTimingCount, marshalledPresentationTimings);
                if (marshalledPresentationTimings != null)
                {
                    var fieldPointer = new PastPresentationTiming[(uint)(marshalledPresentationTimingCount)];
                    for(int index = 0; index < (uint)(marshalledPresentationTimingCount); index++)
                    {
                        fieldPointer[index] = marshalledPresentationTimings[index];
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
