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
            //unsafe
            //{
            //    var applicationInfoPointer = Interop.ApplicationInfo.Create();
            //    applicationInfoPointer->SType = StructureType.ApplicationInfo;
            //    applicationInfoPointer->ApplicationName = MarshalString("Test Harness");
            //    applicationInfoPointer->EngineName = MarshalString("SharpVk");
            //    applicationInfoPointer->ApiVersion = (uint)Math.Pow(2, 22) + 2;

            //    char*[] enabledExtensions = new [] { MarshalString("VK_KHR_surface"), MarshalString("VK_KHR_win32_surface") };
            //    Interop.Instance instance;

            //    fixed (char** enabledExtesionsPointer = enabledExtensions)
            //    {
            //        var instanceInfoPointer = Interop.InstanceCreateInfo.Create();
            //        instanceInfoPointer->SType = StructureType.InstanceCreateInfo;
            //        instanceInfoPointer->ApplicationInfo = applicationInfoPointer;
            //        instanceInfoPointer->EnabledExtensionCount = 2;
            //        instanceInfoPointer->EnabledExtensionNames = enabledExtesionsPointer;

            //        Result vr = Interop.NativeMethods.vkCreateInstance(instanceInfoPointer, null, &instance);

            //        Console.WriteLine("Result: {0}, Instance: {1}", vr, instance.Handle);
            //    }

            //    uint gpuCount = 0;
            //    Result vr2 = Interop.NativeMethods.vkEnumeratePhysicalDevices(instance, &gpuCount, null);

            //    Console.WriteLine("Result: {0}, GPU Count: {1}", vr2, gpuCount);

            //    Interop.NativeMethods.vkDestroyInstance(instance, null);
            //}
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
