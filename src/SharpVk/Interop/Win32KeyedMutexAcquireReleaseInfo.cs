using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct Win32KeyedMutexAcquireReleaseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint AcquireCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory* AcquireSyncs; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong* AcquireKeys; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* AcquireTimeouts; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ReleaseCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory* ReleaseSyncs; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong* ReleaseKeys; 
    }
}
