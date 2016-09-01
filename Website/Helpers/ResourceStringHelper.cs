using System.Reflection;
using System.Resources;

namespace Website.Helpers
{
    public class ResourceStringHelper
    {
        public static string GetResourceString(string key)
        {
            var result = "";
            var rm = new ResourceManager("Website.Resources.Content", Assembly.GetExecutingAssembly());
            result = rm.GetString(key);

            return result;
        }
    }
}