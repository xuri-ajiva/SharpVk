using System;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var layers = Instance.EnumerateLayerProperties();
        }
    }
}