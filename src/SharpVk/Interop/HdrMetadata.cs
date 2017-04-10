using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct HdrMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        public HdrMetadata(StructureType sType, void* next, XYColor displayPrimaryRed, XYColor displayPrimaryGreen, XYColor displayPrimaryBlue, XYColor whitePoint, float maxLuminance, float minLuminance, float maxContentLightLevel, float maxFrameAverageLightLevel)
        {
            this.SType = sType;
            this.Next = next;
            this.DisplayPrimaryRed = displayPrimaryRed;
            this.DisplayPrimaryGreen = displayPrimaryGreen;
            this.DisplayPrimaryBlue = displayPrimaryBlue;
            this.WhitePoint = whitePoint;
            this.MaxLuminance = maxLuminance;
            this.MinLuminance = minLuminance;
            this.MaxContentLightLevel = maxContentLightLevel;
            this.MaxFrameAverageLightLevel = maxFrameAverageLightLevel;
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
        public XYColor DisplayPrimaryRed; 
        
        /// <summary>
        /// 
        /// </summary>
        public XYColor DisplayPrimaryGreen; 
        
        /// <summary>
        /// 
        /// </summary>
        public XYColor DisplayPrimaryBlue; 
        
        /// <summary>
        /// 
        /// </summary>
        public XYColor WhitePoint; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxLuminance; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinLuminance; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxContentLightLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxFrameAverageLightLevel; 
    }
}
