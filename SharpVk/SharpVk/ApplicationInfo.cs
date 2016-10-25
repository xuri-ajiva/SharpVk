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
    /// Structure specifying application info.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:apiVersion must: be zero, or otherwise it
    /// must: be a version that the implementation supports, or supports an
    /// effective substitute for ****
    /// </para>
    /// </summary>
    public struct ApplicationInfo
    {
        /// <summary>
        /// pname:pApplicationName is a pointer to a null-terminated UTF-8
        /// string containing the name of the application.
        /// </summary>
        public string ApplicationName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:applicationVersion is an unsigned integer variable containing
        /// the developer-supplied version number of the application.
        /// </summary>
        public Version ApplicationVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pEngineName is a pointer to a null-terminated UTF-8 string
        /// containing the name of the engine (if any) used to create the
        /// application.
        /// </summary>
        public string EngineName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:engineVersion is an unsigned integer variable containing the
        /// developer-supplied version number of the engine used to create the
        /// application.
        /// </summary>
        public Version EngineVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:apiVersion is the version of the Vulkan API against which the
        /// application expects to run, encoded as described in the
        /// &lt;&lt;fundamentals-versionnum,API Version Numbers and
        /// Semantics&gt;&gt; section. If pname:apiVersion is 0 the
        /// implementation must: ignore it, otherwise if the implementation
        /// does not support the requested pname:apiVersion it must: return
        /// ename:VK_ERROR_INCOMPATIBLE_DRIVER. The patch version number
        /// specified in pname:apiVersion is ignored when creating an instance
        /// object. Only the major and minor versions of the instance must:
        /// match those requested in pname:apiVersion.
        /// </summary>
        public Version ApiVersion
        {
            get;
            set;
        }
        
        internal unsafe Interop.ApplicationInfo Pack()
        {
            Interop.ApplicationInfo result = default(Interop.ApplicationInfo);
            result.SType = StructureType.ApplicationInfo;
            result.ApplicationName = Interop.HeapUtil.MarshalTo(this.ApplicationName);
            result.ApplicationVersion = (uint)this.ApplicationVersion;
            result.EngineName = Interop.HeapUtil.MarshalTo(this.EngineName);
            result.EngineVersion = (uint)this.EngineVersion;
            result.ApiVersion = (uint)this.ApiVersion;
            return result;
        }
        
        internal unsafe Interop.ApplicationInfo* MarshalTo()
        {
            return (Interop.ApplicationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
