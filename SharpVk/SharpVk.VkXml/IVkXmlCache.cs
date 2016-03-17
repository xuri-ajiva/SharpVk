using System.Xml.Linq;

namespace SharpVk.VkXml
{
    public interface IVkXmlCache
    {
        XDocument GetVkXml();
    }
}