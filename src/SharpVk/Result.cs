namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// 
        /// </summary>
        Success = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        NotReady = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Timeout = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        EventSet = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        EventReset = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        Incomplete = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorOutOfHostMemory = -1, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorOutOfDeviceMemory = -2, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorInitializationFailed = -3, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorDeviceLost = -4, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorMemoryMapFailed = -5, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorLayerNotPresent = -6, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorExtensionNotPresent = -7, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorFeatureNotPresent = -8, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorIncompatibleDriver = -9, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorTooManyObjects = -10, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorFormatNotSupported = -11, 
        
        /// <summary>
        /// 
        /// </summary>
        ErrorFragmentedPool = -12, 
    }
}
