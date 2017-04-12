namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryPipelineStatisticFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAssemblyVertices = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAssemblyPrimitives = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexShaderInvocations = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryShaderInvocations = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryShaderPrimitives = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ClippingInvocations = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        ClippingPrimitives = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShaderInvocations = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationControlShaderPatches = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationEvaluationShaderInvocations = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        ComputeShaderInvocations = 1 << 10, 
    }
}
