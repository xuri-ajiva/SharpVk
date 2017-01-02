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
    /// <para>
    /// Vulkan command return codes.
    /// </para>
    /// <para>
    /// While the core Vulkan API is not designed to capture incorrect usage,
    /// some circumstances still require return codes. Commands in Vulkan
    /// return their status via return codes that are in one of two categories:
    /// </para>
    /// <para>
    /// * Successful completion codes are returned when a command needs to
    /// communicate success or status information. All successful completion
    /// codes are non-negative values. * Run time error codes are returned when
    /// a command needs to communicate a failure that could only be detected at
    /// run time. All run time error codes are negative values.
    /// </para>
    /// <para>
    /// .Success Codes * ename:VK_SUCCESS Command successfully completed *
    /// ename:VK_NOT_READY A fence or query has not yet completed *
    /// ename:VK_TIMEOUT A wait operation has not completed in the specified
    /// time * ename:VK_EVENT_SET An event is signaled * ename:VK_EVENT_RESET
    /// An event is unsignaled * ename:VK_INCOMPLETE A return array was too
    /// small for the result ifdef::VK_KHR_swapchain[] *
    /// ename:VK_SUBOPTIMAL_KHR A swapchain no longer matches the surface
    /// properties exactly, but can: still be used to present to the surface
    /// successfully. endif::VK_KHR_swapchain[]
    /// </para>
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// Command completed successfully
        /// </summary>
        Success = 0, 
        
        /// <summary>
        /// A fence or query has not yet completed
        /// </summary>
        NotReady = 1, 
        
        /// <summary>
        /// A wait operation has not completed in the specified time
        /// </summary>
        Timeout = 2, 
        
        /// <summary>
        /// An event is signaled
        /// </summary>
        EventSet = 3, 
        
        /// <summary>
        /// An event is unsignaled
        /// </summary>
        EventReset = 4, 
        
        /// <summary>
        /// A return array was too small for the result
        /// </summary>
        Incomplete = 5, 
        
        /// <summary>
        /// A host memory allocation has failed
        /// </summary>
        ErrorOutOfHostMemory = -1, 
        
        /// <summary>
        /// A device memory allocation has failed
        /// </summary>
        ErrorOutOfDeviceMemory = -2, 
        
        /// <summary>
        /// Initialization of a object has failed
        /// </summary>
        ErrorInitializationFailed = -3, 
        
        /// <summary>
        /// The logical device has been lost. See
        /// &lt;&lt;devsandqueues-lost-device&gt;&gt;
        /// </summary>
        ErrorDeviceLost = -4, 
        
        /// <summary>
        /// Mapping of a memory object has failed
        /// </summary>
        ErrorMemoryMapFailed = -5, 
        
        /// <summary>
        /// Layer specified does not exist
        /// </summary>
        ErrorLayerNotPresent = -6, 
        
        /// <summary>
        /// Extension specified does not exist
        /// </summary>
        ErrorExtensionNotPresent = -7, 
        
        /// <summary>
        /// Requested feature is not available on this device
        /// </summary>
        ErrorFeatureNotPresent = -8, 
        
        /// <summary>
        /// Unable to find a Vulkan driver
        /// </summary>
        ErrorIncompatibleDriver = -9, 
        
        /// <summary>
        /// Too many objects of the type have already been created
        /// </summary>
        ErrorTooManyObjects = -10, 
        
        /// <summary>
        /// Requested format is not supported on this device
        /// </summary>
        ErrorFormatNotSupported = -11, 
        
        /// <summary>
        /// A requested pool allocation has failed due to fragmentation of the
        /// pool's memory
        /// </summary>
        ErrorFragmentedPool = -12, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorSurfaceLost = -1000000000, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorNativeWindowInUse = -1000000001, 
        
        /// <summary>
        /// -
        /// </summary>
        Suboptimal = 1000001003, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorOutOfDate = -1000001004, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorIncompatibleDisplay = -1000003001, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorValidationFailed = -1000011001, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorInvalidShader = -1000012000, 
    }
}
