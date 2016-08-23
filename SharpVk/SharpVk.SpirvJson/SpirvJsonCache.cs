using System;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace SharpVk.SpirvJson
{
    public class SpirvJsonCache
    {
        private readonly string tempFilePath;

        public SpirvJsonCache(string tempFilePath)
        {
            this.tempFilePath = tempFilePath;

            if(!Directory.Exists(this.tempFilePath))
            {
                Directory.CreateDirectory(this.tempFilePath);
            }
        }

        public SpirvModel GetSpirvModel()
        {
            string tempFile = GetJsonFile("spirv.json");

            return Newtonsoft.Json.JsonConvert.DeserializeObject<SpirvModel>(File.ReadAllText(tempFile));
        }

        public SpirvGrammarModel GetSpirvGrammar()
        {
            string tempFile = GetJsonFile("spirv.core.grammar.json");

            return Newtonsoft.Json.JsonConvert.DeserializeObject<SpirvGrammarModel>(File.ReadAllText(tempFile));
        }

        private string GetJsonFile(string fileName)
        {
            string tempFile = Path.Combine(this.tempFilePath, fileName);

            if (!File.Exists(tempFile) || File.GetLastWriteTimeUtc(tempFile) + TimeSpan.FromDays(1) < DateTime.UtcNow)
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(tempFile));

                    var fileRequest = WebRequest.Create("https://www.khronos.org/registry/spir-v/api/1.1/" + fileName);

                    using (var fileResponse = fileRequest.GetResponse())
                    using (var fileStream = File.OpenWrite(tempFile))
                    {
                        fileResponse.GetResponseStream().CopyTo(fileStream);
                    }
                }
                catch
                {
                }
            }

            return tempFile;
        }
    }
}