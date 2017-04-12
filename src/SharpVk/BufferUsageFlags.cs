namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum BufferUsageFlags
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
        UniformTexelBuffer = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformBuffer = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageBuffer = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexBuffer = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexBuffer = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectBuffer = 1 << 8, 
    }
}
