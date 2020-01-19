// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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

namespace SharpVk.Intel
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// Initialize a device for performance queries
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="initializeInfo">
        /// The initialization parameters.
        /// </param>
        public static unsafe void InitializePerformanceApi(this SharpVk.Device extendedHandle, SharpVk.Intel.InitializePerformanceApiInfo initializeInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Intel.InitializePerformanceApiInfo* marshalledInitializeInfo = default(SharpVk.Interop.Intel.InitializePerformanceApiInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInitializeInfo = (SharpVk.Interop.Intel.InitializePerformanceApiInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.InitializePerformanceApiInfo>());
                initializeInfo.MarshalTo(marshalledInitializeInfo);
                SharpVk.Interop.Intel.VkDeviceInitializePerformanceApiDelegate commandDelegate = commandCache.Cache.vkInitializePerformanceApiINTEL;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInitializeInfo);
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void UninitializePerformanceApi(this SharpVk.Device extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Intel.VkDeviceUninitializePerformanceApiDelegate commandDelegate = commandCache.Cache.vkUninitializePerformanceApiINTEL;
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Acquire the performance query capability
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="type">
        /// One of the VkPerformanceConfigurationTypeINTEL type of performance
        /// configuration that will be acquired.
        /// </param>
        public static unsafe SharpVk.Intel.PerformanceConfiguration AcquirePerformanceConfiguration(this SharpVk.Device extendedHandle, SharpVk.Intel.PerformanceConfigurationType type)
        {
            try
            {
                SharpVk.Intel.PerformanceConfiguration result = default(SharpVk.Intel.PerformanceConfiguration);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Intel.PerformanceConfigurationAcquireInfo* marshalledAcquireInfo = default(SharpVk.Interop.Intel.PerformanceConfigurationAcquireInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.Intel.PerformanceConfiguration marshalledConfiguration = default(SharpVk.Interop.Intel.PerformanceConfiguration);
                commandCache = extendedHandle.commandCache;
                marshalledAcquireInfo = (SharpVk.Interop.Intel.PerformanceConfigurationAcquireInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.PerformanceConfigurationAcquireInfo>());
                marshalledAcquireInfo->SType = StructureType.PerformanceConfigurationAcquireInfo;
                marshalledAcquireInfo->Next = nextPointer;
                marshalledAcquireInfo->Type = type;
                SharpVk.Interop.Intel.VkDeviceAcquirePerformanceConfigurationDelegate commandDelegate = commandCache.Cache.vkAcquirePerformanceConfigurationINTEL;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledAcquireInfo, &marshalledConfiguration);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Intel.PerformanceConfiguration(extendedHandle, marshalledConfiguration);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query performance capabilities of the device
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="parameter">
        /// The parameter to query.
        /// </param>
        public static unsafe SharpVk.Intel.PerformanceValue GetPerformanceParameter(this SharpVk.Device extendedHandle, SharpVk.Intel.PerformanceParameterType parameter)
        {
            try
            {
                SharpVk.Intel.PerformanceValue result = default(SharpVk.Intel.PerformanceValue);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Intel.PerformanceValue marshalledValue = default(SharpVk.Interop.Intel.PerformanceValue);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Intel.VkDeviceGetPerformanceParameterDelegate commandDelegate = commandCache.Cache.vkGetPerformanceParameterINTEL;
                Result methodResult = commandDelegate(extendedHandle.handle, parameter, &marshalledValue);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Intel.PerformanceValue.MarshalFrom(&marshalledValue);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
