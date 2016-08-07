using SharpVk.VkXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SharpVk
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GenerateTypes();

            var instance = Instance.CreateInstance(new InstanceCreateInfo
            {
                ApplicationInfo = new ApplicationInfo
                {
                    ApplicationName = "Example Application",
                    EngineName = "SharpVK"
                },
                EnabledExtensionNames = new[] { "VK_KHR_surface", "VK_KHR_win32_surface" }
            }, null);

            var physicalDevices = instance.EnumeratePhysicalDevices();

            var deviceCreateInfo = new DeviceCreateInfo
            {
                QueueCreateInfos = new[]
                {
                    new DeviceQueueCreateInfo
                    {
                        QueueFamilyIndex = 0,
                        QueuePriorities = new float[] { 1 }
                    }
                }
            };

            var surfaceForm = new Form
            {
                Height = 720,
                Width = 1280
            };

            var surfaceCreateInfo = new Win32SurfaceCreateInfo
            {
                Flags = Win32SurfaceCreateFlags.None,
                Hinstance = IntPtr.Zero,
                Hwnd = surfaceForm.Handle
            };

            var surface = instance.CreateWin32Surface(surfaceCreateInfo, null);

            var swapchainInfo = new SwapchainCreateInfo
            {
                Surface = surface,
                Flags = SwapchainCreateFlags.None,
                PresentMode = PresentMode.Immediate
            };

            var devices = new List<Device>();

            foreach (var physicalDevice in physicalDevices)
            {
                var device = physicalDevice.CreateDevice(deviceCreateInfo, null);

                Enumerate(physicalDevice.GetPhysicalDeviceSurfaceCapabilities(surface));

                var swapchain = device.CreateSwapchain(swapchainInfo, null);

                var images = swapchain.GetSwapchainImages();

                swapchain.DestroySwapchain(null);

                devices.Add(device);
            }
            
            surfaceForm.ShowDialog();

            foreach (var device in devices)
            {
                device.DestroyDevice(null);
            }

            surface.DestroySurface(null);

            instance.DestroyInstance(null);
        }

        private static void Enumerate<T>(T target)
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", field.Name, field.GetValue(target));
            }

            foreach (var property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", property.Name, property.GetValue(target));
            }
        }

        private static void GenerateTypes()
        {
            var xmlCache = new VkXmlCache(".\\obj\\VkTemplates");

            var parser = new SpecParser(xmlCache);
            var generator = new TypeGenerator();

            var types = generator.Generate(parser.Run());
        }
    }
}