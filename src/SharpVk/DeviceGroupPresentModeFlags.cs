namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceGroupPresentModeFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Local = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Remote = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Sum = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        LocalMultiDevice = 1 << 3, 
    }
}
