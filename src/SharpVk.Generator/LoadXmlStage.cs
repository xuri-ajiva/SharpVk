using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System.IO;

namespace SharpVk.Generator
{
    public class LoadXmlStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "SharpVk");

            if (!Directory.Exists(tempFilePath))
            {
                Directory.CreateDirectory(tempFilePath);
            }

            services.AddSingleton<IVkXmlCache>(new VkXmlCache(tempFilePath));
        }
    }
}
