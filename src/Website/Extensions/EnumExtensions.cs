using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Website.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var element = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First();
            var attr = (DisplayAttribute)Attribute.GetCustomAttribute(element, typeof(DisplayAttribute));
            if (attr != null && !string.IsNullOrEmpty(attr.Name))
            {
                return attr.Name;
            }

            return enumValue.ToString();
        }
    }
}