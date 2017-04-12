namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalMemoryHandleTypeFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        OpaqueFileDescriptor = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        OpaqueWin32 = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        OpaqueWin32Kmt = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d11Texture = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d11TextureKmt = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d12Heap = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d12Resource = 1 << 6, 
    }
}
