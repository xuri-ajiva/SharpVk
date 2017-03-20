using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ExternalMemoryProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ExternalMemoryProperties(ExternalMemoryFeatureFlags externalMemoryFeatures, ExternalMemoryHandleTypeFlags exportFromImportedHandleTypes, ExternalMemoryHandleTypeFlags compatibleHandleTypes)
        {
            this.ExternalMemoryFeatures = externalMemoryFeatures;
            this.ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.CompatibleHandleTypes = compatibleHandleTypes;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalMemoryFeatureFlags ExternalMemoryFeatures; 
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes; 
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalMemoryHandleTypeFlags CompatibleHandleTypes; 
    }
}
