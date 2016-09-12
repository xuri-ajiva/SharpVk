










//The MIT License (MIT)
//
//Copyright (c) Andrew Armstrong/FacticiusVir 2016
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.


using System;

namespace SharpVk
{

    /// <summary>
    /// <para>
    /// Application-defined memory allocation function.
    /// </para>
    /// </summary>
	public delegate IntPtr AllocationFunctionDelegate(IntPtr userData, Size size, Size alignment, SystemAllocationScope allocationScope);

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public delegate Bool32 DebugReportCallbackDelegate(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, Size location, int messageCode, string layerPrefix, string message, IntPtr userData);

    /// <summary>
    /// <para>
    /// Application-defined memory free function.
    /// </para>
    /// </summary>
	public delegate void FreeFunctionDelegate(IntPtr userData, IntPtr memory);

    /// <summary>
    /// <para>
    /// Application-defined memory allocation notification function.
    /// </para>
    /// </summary>
	public delegate void InternalAllocationNotificationDelegate(IntPtr userData, Size size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);

    /// <summary>
    /// <para>
    /// Application-defined memory free notification function.
    /// </para>
    /// </summary>
	public delegate void InternalFreeNotificationDelegate(IntPtr userData, Size size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);

    /// <summary>
    /// <para>
    /// Application-defined memory reallocation function.
    /// </para>
    /// </summary>
	public delegate IntPtr ReallocationFunctionDelegate(IntPtr userData, IntPtr original, Size size, Size alignment, SystemAllocationScope allocationScope);

    /// <summary>
    /// <para>
    /// Dummy function pointer type returned by queries.
    /// </para>
    /// </summary>
	public delegate void VoidFunctionDelegate();

}