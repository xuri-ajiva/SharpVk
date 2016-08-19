using System;
using System.IO;
using System.Net;

namespace SharpVk.VkXml
{
    public class DownloadedFileCache
    {
        private readonly string tempFilePath;
        private readonly Uri fileUrl;

        public DownloadedFileCache(string tempFilePath, string fileUrl)
        {
            this.tempFilePath = tempFilePath;
            this.fileUrl = new Uri(fileUrl);

            if (!Directory.Exists(this.tempFilePath))
            {
                Directory.CreateDirectory(this.tempFilePath);
            }
        }

        public string GetFileLocation()
        {
            string fileName = Path.GetFileName(this.fileUrl.AbsolutePath);

            string tempFile = Path.Combine(this.tempFilePath, fileName);

            if (!File.Exists(tempFile) || File.GetLastWriteTimeUtc(tempFile) + TimeSpan.FromDays(1) < DateTime.UtcNow)
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(tempFile));

                    var fileRequest = WebRequest.Create(this.fileUrl);

                    using (var fileResponse = fileRequest.GetResponse())
                    using (var tempFileStream = File.OpenWrite(tempFile))
                    {
                        fileResponse.GetResponseStream().CopyTo(tempFileStream);
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
