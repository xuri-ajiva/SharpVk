﻿using System.Runtime.InteropServices;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Represents a single video mode.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VideoMode
    {
        private readonly int width;

        private readonly int height;

        private readonly int redBits;

        private readonly int greenBits;

        private readonly int blueBits;

        /// <summary>
        ///     The resolution, in screen coordinates, of the video mode.
        /// </summary>
        public (int Width, int Height) Resolution => (width, height);

        /// <summary>
        ///     The bit depth of the red channel of the video mode.
        /// </summary>
        public (int Red, int Green, int Blue) Bits => (redBits, greenBits, blueBits);

        /// <summary>
        ///     The refresh rate, in Hz, of the video mode.
        /// </summary>
        public int RefreshRate;

        /// <summary>
        ///     Returns a string representation of this video mode.
        /// </summary>
        /// <returns>
        ///     A string representation of this video mode.
        /// </returns>
        public override string ToString()
        {
            return $"[Resolution: {Resolution}, Bit Depth: {Bits}, Refresh Rate: {RefreshRate}Hz]";
        }
    }
}