namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormatFeatureFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImage = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImage = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageAtomic = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBuffer = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBufferAtomic = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexBuffer = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachment = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentBlend = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachment = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        BlitSource = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        BlitDestination = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterLinear = 1 << 12, 
    }
}
