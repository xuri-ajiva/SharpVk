namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageAspectFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Color = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Depth = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Stencil = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Metadata = 1 << 3, 
    }
}
