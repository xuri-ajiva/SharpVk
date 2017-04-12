namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryResultFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        QueryResult64 = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Wait = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        WithAvailability = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Partial = 1 << 3, 
    }
}
