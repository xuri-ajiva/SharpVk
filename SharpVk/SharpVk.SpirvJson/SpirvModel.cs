using System.Collections.Generic;

namespace SharpVk.SpirvJson
{
    public struct SpirvModel
    {
        public SpirvData Spv;
    }

    public struct SpirvData
    {
        public SpirvEnum[] Enum;
    }

    public struct SpirvEnum
    {
        public string Name;
        public string Type;
        public Dictionary<string, int> Values;
    }
}