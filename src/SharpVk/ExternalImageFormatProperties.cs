using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ExternalImageFormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ExternalImageFormatProperties(ImageFormatProperties imageFormatProperties, ExternalMemoryFeatureFlags externalMemoryFeatures, ExternalMemoryHandleTypeFlags exportFromImportedHandleTypes, ExternalMemoryHandleTypeFlags compatibleHandleTypes)
        {
            this.ImageFormatProperties = imageFormatProperties;
            this.ExternalMemoryFeatures = externalMemoryFeatures;
            this.ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.CompatibleHandleTypes = compatibleHandleTypes;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageFormatProperties ImageFormatProperties; 
        
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
