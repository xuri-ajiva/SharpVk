using System.Linq;
using System.Reflection;

namespace SharpVk
{
    /// <summary>
    /// Represents a Semantic Version number encoded as a UInt32
    /// </summary>
    public struct Version
    {
        private uint value;

        /// <summary>
        /// Create a new version number with the specified values.
        /// </summary>
        /// <param name="major">
        /// The Major version number.
        /// </param>
        /// <param name="minor">
        /// The Minor version number.
        /// </param>
        /// <param name="patch">
        /// The Patch version number.
        /// </param>
        public Version(int major, int minor, int patch)
        {
            this.value = (uint)major << 22 | (uint)minor << 12 | (uint)patch;
        }

        /// <summary>
        /// The Major version number.
        /// </summary>
        public int Major
        {
            get
            {
                return (int)(value >> 22);
            }
        }

        /// <summary>
        /// The Minor version number.
        /// </summary>
        public int Minor
        {
            get
            {
                return (int)(value >> 12) & 0x3ff;
            }
        }

        /// <summary>
        /// The Patch version number.
        /// </summary>
        public int Patch
        {
            get
            {
                return (int)(value) & 0xfff;
            }
        }

        /// <summary>
        /// Implicit conversion of a UInt32 value to a decoded Version number.
        /// </summary>
        /// <param name="value">
        /// A semantic version number encoded as a UInt32.
        /// </param>
        public static implicit operator Version(uint value)
        {
            return new Version { value = value };
        }

        /// <summary>
        /// Explicit conversion of a Version number to an encoded UInt32.
        /// </summary>
        /// <param name="size">
        /// The version number value to encode.
        /// </param>
        public static explicit operator uint(Version size)
        {
            return size.value;
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>
        /// A version string of the format "{Major}.{Minor}.{Patch}".
        /// </returns>
        public override string ToString()
        {
            return $"{this.Major}.{this.Minor}.{this.Patch}";
        }

        internal static Version ExtractBindingVersion()
        {
            var versionAttribute = typeof(Version).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            string versionString = versionAttribute.InformationalVersion;

            int firstDecimalIndex = versionString.IndexOf('.');
            int secondDecimalIndex = versionString.IndexOf('.', firstDecimalIndex + 1);
            int terminatorIndex = versionString.Skip(secondDecimalIndex + 1).TakeWhile(char.IsDigit).Count() + secondDecimalIndex + 1;

            int major = int.Parse(versionString.Substring(0, firstDecimalIndex));
            int minor = int.Parse(versionString.Substring(firstDecimalIndex + 1, (secondDecimalIndex - firstDecimalIndex) - 1));
            int patch = int.Parse(versionString.Substring(secondDecimalIndex + 1, (terminatorIndex - secondDecimalIndex) - 1));

            return new Version(major, minor, patch);
        }
    }
}