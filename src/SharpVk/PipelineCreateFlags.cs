namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineCreateFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Derivative = 1 << 2, 
    }
}
