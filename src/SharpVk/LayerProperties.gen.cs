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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying layer properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LayerProperties
    {
        /// <summary>
        /// pname:layerName is a null-terminated UTF-8 string specifying the
        /// name of the layer. Use this name in the pname:ppEnabledLayerNames
        /// array passed in the slink:VkInstanceCreateInfo structure to enable
        /// this layer for an instance.
        /// </summary>
        public string LayerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:specVersion is the Vulkan version the layer was written to,
        /// encoded as described in the &lt;&lt;fundamentals-versionnum,API
        /// Version Numbers and Semantics&gt;&gt; section.
        /// </summary>
        public Version SpecVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:implementationVersion is the version of this layer. It is an
        /// integer, increasing with backward compatible changes.
        /// </summary>
        public Version ImplementationVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:description is a null-terminated UTF-8 string providing
        /// additional details that can: be used by the application to identify
        /// the layer.
        /// </summary>
        public string Description
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe LayerProperties MarshalFrom(SharpVk.Interop.LayerProperties* pointer)
        {
            LayerProperties result = default(LayerProperties);
            result.LayerName = Interop.HeapUtil.MarshalStringFrom(pointer->LayerName, Constants.MaxExtensionNameSize, true);
            result.SpecVersion = (Version)(pointer->SpecVersion);
            result.ImplementationVersion = (Version)(pointer->ImplementationVersion);
            result.Description = Interop.HeapUtil.MarshalStringFrom(pointer->Description, Constants.MaxDescriptionSize, true);
            return result;
        }
    }
}
