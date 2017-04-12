using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct AllocationCallbacks
    {
        /// <summary>
        /// 
        /// </summary>
        public void* UserData; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Allocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Reallocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Free; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr InternalAllocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr InternalFree; 
    }
}
