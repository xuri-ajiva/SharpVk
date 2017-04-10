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
        public ExternalSemaphoreProperties(StructureType sType, void* next, ExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes, ExternalSemaphoreHandleTypeFlags compatibleHandleTypes, ExternalSemaphoreFeatureFlags externalSemaphoreFeatures)
        {
            this.SType = sType;
            this.Next = next;
            this.ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.CompatibleHandleTypes = compatibleHandleTypes;
            this.ExternalSemaphoreFeatures = externalSemaphoreFeatures;
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
