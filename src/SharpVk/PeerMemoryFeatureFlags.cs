namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum PeerMemoryFeatureFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        CopySource = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        CopyDestination = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        GenericSource = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        GenericDestination = 1 << 3, 
    }
}
