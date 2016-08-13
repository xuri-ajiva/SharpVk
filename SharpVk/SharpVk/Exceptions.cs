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
	public abstract class SharpVkException
		: Exception
	{
		public static bool IsError(Result resultCode)
		{
			return (int)resultCode < 0;
		}

		public static SharpVkException Create(Result resultCode)
		{
			if(!IsError(resultCode))
			{
				return null;
			}

			switch(resultCode)
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
				case Result.ErrorValidationFailed:
					return new ValidationFailedException();
			}

			return new UnknownSharpVkException(resultCode);
		}

		public abstract Result ResultCode
		{
			get;
		}
	}

	public class UnknownSharpVkException
		: SharpVkException
	{
		private Result resultCode;

		public UnknownSharpVkException(Result resultCode)
		{
			this.resultCode = resultCode;
		}

		public override Result ResultCode => this.resultCode;
	}

	public class OutOfHostMemoryException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorOutOfHostMemory;
	}

	public class OutOfDeviceMemoryException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorOutOfDeviceMemory;
	}

	public class InitializationFailedException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorInitializationFailed;
	}

	public class DeviceLostException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorDeviceLost;
	}

	public class MemoryMapFailedException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorMemoryMapFailed;
	}

	public class LayerNotPresentException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorLayerNotPresent;
	}

	public class ExtensionNotPresentException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorExtensionNotPresent;
	}

	public class FeatureNotPresentException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorFeatureNotPresent;
	}

	public class IncompatibleDriverException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorIncompatibleDriver;
	}

	public class TooManyObjectsException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorTooManyObjects;
	}

	public class FormatNotSupportedException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorFormatNotSupported;
	}

	public class FragmentedPoolException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorFragmentedPool;
	}

	public class SurfaceLostException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorSurfaceLost;
	}

	public class NativeWindowInUseException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorNativeWindowInUse;
	}

	public class OutOfDateException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorOutOfDate;
	}

	public class ValidationFailedException
		: SharpVkException
	{
		public override Result ResultCode => Result.ErrorValidationFailed;
	}


}