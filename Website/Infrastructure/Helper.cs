using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace Website.Infrastructure
{
    public class Helper
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