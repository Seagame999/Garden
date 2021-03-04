using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garden.Controllers
{
    public class GardenController : Controller
    {
        // GET: Garden
        public ActionResult Gardens()
        {
            return View();
        }

        public ActionResult Garden1()
        {
            return View();
        }
    }
}