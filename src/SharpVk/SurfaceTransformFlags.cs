namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum SurfaceTransformFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Identity = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Rotate90 = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Rotate180 = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Rotate270 = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        HorizontalMirror = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        HorizontalMirrorRotate90 = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        HorizontalMirrorRotate180 = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        HorizontalMirrorRotate270 = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        Inherit = 1 << 8, 
    }
}
