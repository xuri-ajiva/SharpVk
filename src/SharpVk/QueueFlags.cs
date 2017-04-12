namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueueFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Graphics = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Compute = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Transfer = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseBinding = 1 << 3, 
    }
}
