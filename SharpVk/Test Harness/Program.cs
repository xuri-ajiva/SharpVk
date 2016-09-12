using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SharpVk
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var instance = Instance.Create(new InstanceCreateInfo
            {
                ApplicationInfo = new ApplicationInfo
                {
                },
                EnabledExtensionNames = new string[]
                {
                    ExtDebugReport.ExtensionName
                }
            });

            instance.CreateDebugReportCallback(new DebugReportCallbackCreateInfo
            {
                Flags = DebugReportFlags.Error | DebugReportFlags.Warning | DebugReportFlags.Information | DebugReportFlags.Debug,
                PfnCallback = new DebugReportCallbackDelegate(DebugReport)
            });

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static Bool32 DebugReport(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, Size location, int messageCode, string layerPrefix, string message, IntPtr userData)
        {
            Console.WriteLine(message);

            return true;
        }
    }
}