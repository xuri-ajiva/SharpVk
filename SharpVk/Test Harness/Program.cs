using SharpVk.Interop;
using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    class Program
    {
        private static unsafe char* MarshalString(string value)
        {
            return (char*)Marshal.StringToHGlobalAnsi(value).ToPointer();
        }

        static void Main(string[] args)
        {
            unsafe
            {
                ApplicationInfo* applicationInfoPointer = ApplicationInfo.Create();
                applicationInfoPointer->SType = SharpVk.StructureType.ApplicationInfo;
                applicationInfoPointer->ApplicationName = MarshalString("Example");
                applicationInfoPointer->EngineName = MarshalString("Example");
                applicationInfoPointer->ApiVersion = (uint)Math.Pow(2, 22) + 2;

                char*[] enabledExtensions = new [] { MarshalString("VK_KHR_surface"), MarshalString("VK_KHR_win32_surface") };
                Instance instance;

                fixed (char** enabledExtesionsPointer = enabledExtensions)
                {
                    var instanceInfoPointer = InstanceCreateInfo.Create();
                    instanceInfoPointer->SType = StructureType.InstanceCreateInfo;
                    instanceInfoPointer->ApplicationInfo = applicationInfoPointer;
                    instanceInfoPointer->EnabledExtensionCount = 2;
                    instanceInfoPointer->EnabledExtensionNames = enabledExtesionsPointer;

                    Result vr = NativeMethods.vkCreateInstance(instanceInfoPointer, null, &instance);

                    Console.WriteLine("Result: {0}, Instance: {1}", vr, instance.Handle);
                }

                uint gpuCount = 0;
                Result vr2 = NativeMethods.vkEnumeratePhysicalDevices(instance, &gpuCount, null);

                Console.WriteLine("Result: {0}, GPU Count: {1}", vr2, gpuCount);
                
                NativeMethods.vkDestroyInstance(instance, null);
            }
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
