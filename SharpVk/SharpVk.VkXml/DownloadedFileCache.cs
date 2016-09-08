using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace SharpVk.VkXml
{
    public class DownloadedFileCache
    {
        private readonly HttpClient client;
        private readonly string tempFilePath;
        private readonly Uri fileUrl;

        public DownloadedFileCache(string tempFilePath, string fileUrl)
        {
            this.tempFilePath = tempFilePath;
            this.fileUrl = new Uri(fileUrl);
            this.client = new HttpClient();

            if (!Directory.Exists(this.tempFilePath))
            {
                Directory.CreateDirectory(this.tempFilePath);
            }
        }

        public async Task<string> GetFileLocation()
        {
            string fileName = Path.GetFileName(this.fileUrl.AbsolutePath);

            string tempFile = Path.Combine(this.tempFilePath, fileName);

            if (!File.Exists(tempFile) || File.GetLastWriteTimeUtc(tempFile) + TimeSpan.FromDays(1) < DateTime.UtcNow)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(tempFile));

                using (var fileResponse = this.client.GetAsync(this.fileUrl).Result)
                {
                    if (fileResponse.IsSuccessStatusCode)
                    {
                        using (var tempFileStream = File.OpenWrite(tempFile))
                        {
                            await fileResponse.Content.CopyToAsync(tempFileStream);
                        }
                    }
                }
            }

            return tempFile;
        }
    }
}
