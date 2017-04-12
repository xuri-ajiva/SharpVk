namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndirectCommandsLayoutUsageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        UnorderedSequences = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseSequences = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        EmptyExecutions = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexedSequences = 1 << 3, 
    }
}
