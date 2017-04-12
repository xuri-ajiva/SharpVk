namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageUsageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferSource = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferDestination = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Sampled = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Storage = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachment = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachment = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        TransientAttachment = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachment = 1 << 7, 
    }
}
