namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalSemaphoreHandleTypeFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        OpaqueFileDescriptor = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        OpaqueWin32 = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        OpaqueWin32Kmt = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d12Fence = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceFileDescriptor = 1 << 4, 
    }
}
