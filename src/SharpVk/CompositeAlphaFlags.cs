namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompositeAlphaFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Opaque = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        PreMultiplied = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        PostMultiplied = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Inherit = 1 << 3, 
    }
}
