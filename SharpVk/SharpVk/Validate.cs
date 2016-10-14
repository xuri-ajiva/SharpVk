using System;

namespace SharpVk
{
    internal static class Validate
    {
        internal static void CheckLength<T>(T[] array, int length, string name)
        {
            if (array.Length != length)
            {
                throw new Exception($"Array {name} is incorrect length; should be {length} elements");
            }
        }
    }
}
