using System;

namespace SharpVk.Khronos
{
    public partial class Surface : IEquatable<Surface?>
    {
        /// <summary>
        ///     Create a new Surface instance from an externally created handle.
        /// </summary>
        /// <param name="instance">
        ///     The Vulkan Instance against which the handle was created.
        /// </param>
        /// <param name="handle">
        ///     An unsigned 64-bit integer representing the created Surface.
        /// </param>
        /// <returns>
        ///     A Surface instance.
        /// </returns>
        public static Surface CreateFromHandle(Instance instance, ulong handle)
        {
            return new(instance, new(handle));
        }

        /// <inheritdoc />
        public bool Equals(Surface other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Handle.Equals(other.Handle);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Surface)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }
    }
}