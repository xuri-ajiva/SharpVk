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
    /// The base type for exceptions thrown by the SharpVK library.
    /// </summary>
    public abstract class SharpVkException
        : Exception
    {
        /// <summary>
        /// Creates a new instance of the <see
        /// cref="SharpVk.SharpVkException"/> class .
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        protected SharpVkException(string message)
            : base(message)
        {
        }
        
        /// <summary>
        /// Returns a value indicating whether the given Vulkan result code
        /// represents an error.
        /// </summary>
        public static bool IsError(Result resultCode)
        {
            return (int)resultCode < 0;
        }
        
        /// <summary>
        /// Creates and returns a new, specifically-typed exception that
        /// represents the given result code.
        /// </summary>
        public static SharpVkException Create(Result resultCode)
        {
            if (!SharpVkException.IsError(resultCode))
            {
                return null;
            }
            switch (resultCode)
            {
                case Result.ErrorOutOfHostMemory:
                    return new OutOfHostMemoryException();
                case Result.ErrorOutOfDeviceMemory:
                    return new OutOfDeviceMemoryException();
                case Result.ErrorInitializationFailed:
                    return new InitializationFailedException();
                case Result.ErrorDeviceLost:
                    return new DeviceLostException();
                case Result.ErrorMemoryMapFailed:
                    return new MemoryMapFailedException();
                case Result.ErrorLayerNotPresent:
                    return new LayerNotPresentException();
                case Result.ErrorExtensionNotPresent:
                    return new ExtensionNotPresentException();
                case Result.ErrorFeatureNotPresent:
                    return new FeatureNotPresentException();
                case Result.ErrorIncompatibleDriver:
                    return new IncompatibleDriverException();
                case Result.ErrorTooManyObjects:
                    return new TooManyObjectsException();
                case Result.ErrorFormatNotSupported:
                    return new FormatNotSupportedException();
                case Result.ErrorFragmentedPool:
                    return new FragmentedPoolException();
                case Result.ErrorSurfaceLost:
                    return new SurfaceLostException();
                case Result.ErrorNativeWindowInUse:
                    return new NativeWindowInUseException();
                case Result.ErrorOutOfDate:
                    return new OutOfDateException();
                case Result.ErrorIncompatibleDisplay:
                    return new IncompatibleDisplayException();
                case Result.ErrorValidationFailed:
                    return new ValidationFailedException();
                case Result.ErrorInvalidShader:
                    return new InvalidShaderException();
            }
            return new UnknownSharpVkException(resultCode);
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public abstract Result ResultCode
        {
            get;
        }
    }
    
    /// <summary>
    /// An exception representing a result code not recognised by the SharpVk
    /// library.
    /// </summary>
    public class UnknownSharpVkException
        : SharpVkException
    {
        private Result resultCode; 
        
        internal UnknownSharpVkException(Result resultCode)
            : base($"An unknown exception as been thrown by the Vulkan API: {resultCode}")
        {
            this.resultCode = resultCode;
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => this.resultCode;
    }
    
    /// <summary>
    /// A host memory allocation has failed
    /// </summary>
    public class OutOfHostMemoryException
        : SharpVkException
    {
        internal OutOfHostMemoryException()
            : base("A host memory allocation has failed")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfHostMemory;
    }
    
    /// <summary>
    /// A device memory allocation has failed
    /// </summary>
    public class OutOfDeviceMemoryException
        : SharpVkException
    {
        internal OutOfDeviceMemoryException()
            : base("A device memory allocation has failed")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfDeviceMemory;
    }
    
    /// <summary>
    /// Initialization of a object has failed
    /// </summary>
    public class InitializationFailedException
        : SharpVkException
    {
        internal InitializationFailedException()
            : base("Initialization of a object has failed")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInitializationFailed;
    }
    
    /// <summary>
    /// The logical device has been lost. See
    /// &lt;&lt;devsandqueues-lost-device&gt;&gt;
    /// </summary>
    public class DeviceLostException
        : SharpVkException
    {
        internal DeviceLostException()
            : base("The logical device has been lost. See &lt;&lt;devsandqueues-lost-device&gt;&gt;")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorDeviceLost;
    }
    
    /// <summary>
    /// Mapping of a memory object has failed
    /// </summary>
    public class MemoryMapFailedException
        : SharpVkException
    {
        internal MemoryMapFailedException()
            : base("Mapping of a memory object has failed")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorMemoryMapFailed;
    }
    
    /// <summary>
    /// Layer specified does not exist
    /// </summary>
    public class LayerNotPresentException
        : SharpVkException
    {
        internal LayerNotPresentException()
            : base("Layer specified does not exist")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorLayerNotPresent;
    }
    
    /// <summary>
    /// Extension specified does not exist
    /// </summary>
    public class ExtensionNotPresentException
        : SharpVkException
    {
        internal ExtensionNotPresentException()
            : base("Extension specified does not exist")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorExtensionNotPresent;
    }
    
    /// <summary>
    /// Requested feature is not available on this device
    /// </summary>
    public class FeatureNotPresentException
        : SharpVkException
    {
        internal FeatureNotPresentException()
            : base("Requested feature is not available on this device")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFeatureNotPresent;
    }
    
    /// <summary>
    /// Unable to find a Vulkan driver
    /// </summary>
    public class IncompatibleDriverException
        : SharpVkException
    {
        internal IncompatibleDriverException()
            : base("Unable to find a Vulkan driver")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorIncompatibleDriver;
    }
    
    /// <summary>
    /// Too many objects of the type have already been created
    /// </summary>
    public class TooManyObjectsException
        : SharpVkException
    {
        internal TooManyObjectsException()
            : base("Too many objects of the type have already been created")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorTooManyObjects;
    }
    
    /// <summary>
    /// Requested format is not supported on this device
    /// </summary>
    public class FormatNotSupportedException
        : SharpVkException
    {
        internal FormatNotSupportedException()
            : base("Requested format is not supported on this device")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFormatNotSupported;
    }
    
    /// <summary>
    /// A requested pool allocation has failed due to fragmentation of the
    /// pool's memory
    /// </summary>
    public class FragmentedPoolException
        : SharpVkException
    {
        internal FragmentedPoolException()
            : base("A requested pool allocation has failed due to fragmentation of the pool's memory")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFragmentedPool;
    }
    
    /// <summary>
    /// -
    /// </summary>
    public class SurfaceLostException
        : SharpVkException
    {
        internal SurfaceLostException()
            : base("SurfaceLostException")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorSurfaceLost;
    }
    
    /// <summary>
    /// -
    /// </summary>
    public class NativeWindowInUseException
        : SharpVkException
    {
        internal NativeWindowInUseException()
            : base("NativeWindowInUseException")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorNativeWindowInUse;
    }
    
    /// <summary>
    /// -
    /// </summary>
    public class OutOfDateException
        : SharpVkException
    {
        internal OutOfDateException()
            : base("OutOfDateException")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfDate;
    }
    
    /// <summary>
    /// -
    /// </summary>
    public class IncompatibleDisplayException
        : SharpVkException
    {
        internal IncompatibleDisplayException()
            : base("IncompatibleDisplayException")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorIncompatibleDisplay;
    }
    
    /// <summary>
    /// -
    /// </summary>
    public class ValidationFailedException
        : SharpVkException
    {
        internal ValidationFailedException()
            : base("ValidationFailedException")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorValidationFailed;
    }
    
    /// <summary>
    /// -
    /// </summary>
    public class InvalidShaderException
        : SharpVkException
    {
        internal InvalidShaderException()
            : base("InvalidShaderException")
        {
        }
        
        /// <summary>
        /// The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInvalidShader;
    }
}
