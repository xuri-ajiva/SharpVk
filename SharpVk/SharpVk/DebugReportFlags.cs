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
    /// <para>
    /// Bitmask specifying events which cause a debug report callback.
    /// </para>
    /// <para>
    /// For each sname:VkDebugReportCallbackEXT that is created the flags
    /// determine when that function is called. A callback will be made for
    /// issues that match any bit set in its flags. The callback will come
    /// directly from the component that detected the event, unless some other
    /// layer intercepts the calls for its own purposes (filter them in
    /// different way, log to system error log, etc.) An application may
    /// receive multiple callbacks if multiple sname:VkDebugReportCallbackEXT
    /// objects were created. A callback will always be executed in the same
    /// thread as the originating Vulkan call. A callback may be called from
    /// multiple threads simultaneously (if the application is making Vulkan
    /// calls from multiple threads).
    /// </para>
    /// </summary>
    [Flags]
    public enum DebugReportFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_INFORMATION_BIT_EXT indicates an
        /// informational message such as resource details that may be handy
        /// when debugging an application.
        /// </summary>
        Information = 1 << 0, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_WARNING_BIT_EXT indicates use of Vulkan that
        /// may expose an app bug. Such cases may not be immediately harmful,
        /// such as a fragment shader outputting to a location with no
        /// attachment. Other cases may point to behavior that is almost
        /// certainly bad when unintended such as using an image whose memory
        /// hasn't been filled. In general if you see a warning but you know
        /// that the behavior is intended/desired, then simply ignore the
        /// warning.
        /// </summary>
        Warning = 1 << 1, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT indicates a
        /// potentially non-optimal use of Vulkan. E.g. using
        /// flink:vkCmdClearColorImage when a RenderPass load_op would have
        /// worked.
        /// </summary>
        PerformanceWarning = 1 << 2, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_ERROR_BIT_EXT indicates an error that may
        /// cause undefined results, including an application crash.
        /// </summary>
        Error = 1 << 3, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_DEBUG_BIT_EXT indicates diagnostic
        /// information from the loader and layers. -- +
        /// </summary>
        Debug = 1 << 4, 
    }
}
