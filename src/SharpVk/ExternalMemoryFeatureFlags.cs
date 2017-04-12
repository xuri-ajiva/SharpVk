namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalMemoryFeatureFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedOnly = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Exportable = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Importable = 1 << 2, 
    }
}
