using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class MSTestController : Controller
    {
        // GET: MSTest
        public ActionResult MyFirstViewMethod()
        {
            string CutomerName = "Sample Customer Name";
            ViewData["CustName"] = CutomerName;
            return View("MyFirstViewMethod");
        }
    }
}