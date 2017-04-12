namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShaderStageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Vertex = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationControl = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationEvaluation = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Geometry = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Fragment = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        Compute = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        AllGraphics = 0x0000001F, 
        
        /// <summary>
        /// 
        /// </summary>
        All = 0x7FFFFFFF, 
    }
}
