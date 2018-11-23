using SharpVk.Glfw;
using System;
using System.Linq;

namespace SharpVk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().Run();
        }

        private unsafe void Run()
        {
            var extensions = Instance.EnumerateExtensionProperties(null);

            var instance = Instance.Create(null, Glfw3.GetRequiredInstanceExtensions());

            var device = instance.EnumeratePhysicalDevices().First().CreateDevice(new DeviceQueueCreateInfo { QueueFamilyIndex = 0, QueuePriorities = new[] { 0f } }, null, null);

            device.GetQueue(0, 0);

            try
            {
                Glfw3.Init();

                var callback = new CharDelegate((handle, codepoint) => Console.WriteLine(codepoint));

                using (var window = new Window(1920, 1080, "Test"))
                {
                    Glfw3.SetCharCallback(window.Handle, callback);

                    var previous = InputAction.Release;

                    while (!window.ShouldClose)
                    {
                        var mouseAction = Glfw3.GetMouseButton(window.Handle, 1);

                        if (mouseAction != previous)
                        {
                            Console.WriteLine(mouseAction);

                            previous = mouseAction;
                        }

                        Glfw3.PollEvents();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Glfw3.Terminate();
            }
        }
    }
}
