using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public PartialViewResult Sidebar()
        {
            return PartialView("_Sidebar");
        }
    }
}