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
        public AllocationCallbacks(void* userData, IntPtr allocation, IntPtr reallocation, IntPtr free, IntPtr internalAllocation, IntPtr internalFree)
        {
            this.UserData = userData;
            this.Allocation = allocation;
            this.Reallocation = reallocation;
            this.Free = free;
            this.InternalAllocation = internalAllocation;
            this.InternalFree = internalFree;
        }
        
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
