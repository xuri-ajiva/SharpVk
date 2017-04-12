using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ExternalSemaphoreProperties
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
        public ExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes; 
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalSemaphoreHandleTypeFlags CompatibleHandleTypes; 
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures; 
    }
}
