namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum DisplayPlaneAlphaFlags
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
        Global = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        PerPixel = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        PerPixelPremultiplied = 1 << 3, 
    }
}
