namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageCreateFlags
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
        
        /// <summary>
        /// 
        /// </summary>
        MutableFormat = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        CubeCompatible = 1 << 4, 
    }
}
