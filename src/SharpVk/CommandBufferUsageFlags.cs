namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CommandBufferUsageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        OneTimeSubmit = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassContinue = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        SimultaneousUse = 1 << 2, 
    }
}
