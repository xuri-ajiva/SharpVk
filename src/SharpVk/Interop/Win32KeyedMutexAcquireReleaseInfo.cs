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
        public Win32KeyedMutexAcquireReleaseInfo(StructureType sType, void* next, uint acquireCount, DeviceMemory* acquireSyncs, ulong* acquireKeys, uint* acquireTimeouts, uint releaseCount, DeviceMemory* releaseSyncs, ulong* releaseKeys)
        {
            this.SType = sType;
            this.Next = next;
            this.AcquireCount = acquireCount;
            this.AcquireSyncs = acquireSyncs;
            this.AcquireKeys = acquireKeys;
            this.AcquireTimeouts = acquireTimeouts;
            this.ReleaseCount = releaseCount;
            this.ReleaseSyncs = releaseSyncs;
            this.ReleaseKeys = releaseKeys;
        }
        
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
