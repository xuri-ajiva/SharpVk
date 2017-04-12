namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum StencilFaceFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Front = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Back = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        FrontAndBack = 0x00000003, 
    }
}
