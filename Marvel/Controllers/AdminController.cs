﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;

namespace Marvel.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult OverallClinicReport()
        {
            return View();
        }

        public ActionResult Notifications()
        {
            return View();
        }

        public ActionResult Budget()
        {
            return View();
        }


        public ActionResult ArmstrongClinicReport()
        {
            return View();
        }

        public ActionResult MarvelousClinicReport()
        {
            return View();
        }

        public ActionResult ClinicFReport()
        {
            return View();
        }
    }
}