using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marvel.Controllers
{
    public class ResearcherController : Controller
    {
        // GET: Researcher
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}