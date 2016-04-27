namespace SharpVk
{
    public struct Version
    {
        private uint value;

        public Version(int major, int minor, int patch)
        {
            this.value = (uint)major << 22 | (uint)minor << 12 | (uint)patch;
        }

        public int Major
        {
            get
            {
                return (int)(value >> 22);
            }
        }

        public int Minor
        {
            get
            {
                return (int)(value >> 12) & 0x3ff;
            }
        }

        public int Patch
        {
            get
            {
                return (int)(value) & 0xfff;
            }
        }

        public static implicit operator Version(uint value)
        {
            return new Version { value = value };
        }

        public static implicit operator uint(Version size)
        {
            return size.value;
        }
    }
}
