using System.Configuration;
using System.Reflection;
using System.Resources;
using Website.Infrastructure;

namespace Website.Helpers
{
    public class ResourceStringHelper
    {
        public static string GetResourceString(string key)
        {
            var result = "";
            var resourceFile = ConfigurationManager.AppSettings[Constants.AppSettingKeys.ResourceFile];
            var rm = new ResourceManager(resourceFile, Assembly.GetExecutingAssembly());
            result = rm.GetString(key);

            return result;
        }
    }
}