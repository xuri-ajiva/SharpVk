namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoryPropertyFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceLocal = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        HostVisible = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        HostCoherent = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        HostCached = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        LazilyAllocated = 1 << 4, 
    }
}
