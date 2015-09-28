using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AussieDiversServer.Controllers
{
    //Authorize
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string FilePath = Server.MapPath("~/Content/index.html");
            return File(FilePath, "text/html");
        }
    }
}
