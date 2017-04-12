namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum DebugReportFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Information = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Warning = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        PerformanceWarning = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Error = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Debug = 1 << 4, 
    }
}
