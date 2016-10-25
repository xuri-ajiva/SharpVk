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
    /// Structure specifying a extension properties.
    /// </summary>
    public struct ExtensionProperties
    {
        /// <summary>
        /// pname:extensionName is a null-terminated string specifying the name
        /// of the extension.
        /// </summary>
        public string ExtensionName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:specVersion is the version of this extension. It is an
        /// integer, incremented with backward compatible changes.
        /// </summary>
        public Version SpecVersion
        {
            get;
            set;
        }
        
        internal static unsafe ExtensionProperties MarshalFrom(Interop.ExtensionProperties* value)
        {
            ExtensionProperties result = new ExtensionProperties();
            result.ExtensionName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->ExtensionName, (int)Constants.MaxExtensionNameSize, true));
            result.SpecVersion = value->SpecVersion;
            return result;
        }
    }
}
