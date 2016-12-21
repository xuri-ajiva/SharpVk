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
    /// Structure specifying parameters of a newly created debug report
    /// callback.
    /// </summary>
    public struct DebugReportCallbackCreateInfo
    {
        /// <summary>
        /// pname:flags indicate which event(s) will cause this callback to be
        /// called. Flags are interpreted as bitmasks and multiple may be set.
        /// Bits which can: be set include: + --
        /// </summary>
        public DebugReportFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Interop.DebugReportCallbackDelegate PfnCallback
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IntPtr UserData
        {
            get;
            set;
        }
        
        internal unsafe Interop.DebugReportCallbackCreateInfo* MarshalTo()
        {
            var result = (Interop.DebugReportCallbackCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DebugReportCallbackCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DebugReportCallbackCreateInfo* pointer)
        {
            pointer->SType = StructureType.DebugReportCallbackCreateInfo;
            pointer->PfnCallback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnCallback);
            pointer->UserData = this.UserData.ToPointer();
            pointer->Flags = this.Flags;
        }
    }
}
