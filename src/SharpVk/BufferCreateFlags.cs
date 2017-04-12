namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum BufferCreateFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseBinding = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseResidency = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseAliased = 1 << 2, 
    }
}
