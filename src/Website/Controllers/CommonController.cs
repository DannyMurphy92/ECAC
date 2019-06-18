using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public PartialViewResult Sidebar()
        {
            return PartialView("_Sidebar");
        }

        public PartialViewResult SidebarMenu(string identifier)
        {
            var model = new SidebarMenuModel
            {
                Identifier = identifier
            };
            return PartialView("_SidebarMenu", model);
        }
        public PartialViewResult Header()
        {
            return PartialView("_Header");
        }

        public PartialViewResult Footer()
        {
            return PartialView("_Footer");
        }

        public PartialViewResult Navbar()
        {
            return PartialView("_Navbar");
        }
    }
}