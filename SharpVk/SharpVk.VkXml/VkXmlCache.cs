using System;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace SharpVk.VkXml
{
    public class VkXmlCache
        : IVkXmlCache
    {
        private readonly string tempFilePath;

        public VkXmlCache(string tempFilePath)
        {
            this.tempFilePath = tempFilePath;

            if(!Directory.Exists(this.tempFilePath))
            {
                Directory.CreateDirectory(this.tempFilePath);
            }
        }

        public XDocument GetVkXml()
        {
            string tempFile = Path.Combine(this.tempFilePath, "vk.xml");

            if (!File.Exists(tempFile) || File.GetLastWriteTimeUtc(tempFile) + TimeSpan.FromDays(1) < DateTime.UtcNow)
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(tempFile));

                    var vkXmlRequest = WebRequest.Create("https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/1.0/src/spec/vk.xml");

                    using (var vkXmlResponse = vkXmlRequest.GetResponse())
                    using (var fileStream = File.OpenWrite(tempFile))
                    {
                        vkXmlResponse.GetResponseStream().CopyTo(fileStream);
                    }
                }
                catch
                {
                }
            }

            return XDocument.Load(tempFile);
        }
    }
}