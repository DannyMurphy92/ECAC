using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string DesktopTitle { get; set; }
        public string DesktopContent { get; set; }
        public string MobileTitle { get; set; }
        public string MobileContent { get; set; }
    }
}