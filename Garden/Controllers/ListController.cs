using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garden.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult OurTeam()
        {
            return View();
        }

        public ActionResult PopularWord()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

    }
}