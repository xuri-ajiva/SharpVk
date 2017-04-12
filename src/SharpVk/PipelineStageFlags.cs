namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineStageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TopOfPipe = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DrawIndirect = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexInput = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexShader = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationControlShader = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationEvaluationShader = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryShader = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShader = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        EarlyFragmentTests = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        LateFragmentTests = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentOutput = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        ComputeShader = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        Transfer = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        BottomOfPipe = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        Host = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        AllGraphics = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        AllCommands = 1 << 16, 
    }
}
