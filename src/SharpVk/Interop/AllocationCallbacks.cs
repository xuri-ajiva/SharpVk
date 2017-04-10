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
        public AllocationCallbacks(void* userData, IntPtr pfnAllocation, IntPtr pfnReallocation, IntPtr pfnFree, IntPtr pfnInternalAllocation, IntPtr pfnInternalFree)
        {
            this.UserData = userData;
            this.PfnAllocation = pfnAllocation;
            this.PfnReallocation = pfnReallocation;
            this.PfnFree = pfnFree;
            this.PfnInternalAllocation = pfnInternalAllocation;
            this.PfnInternalFree = pfnInternalFree;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void* UserData; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr PfnAllocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr PfnReallocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr PfnFree; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr PfnInternalAllocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr PfnInternalFree; 
    }
}
