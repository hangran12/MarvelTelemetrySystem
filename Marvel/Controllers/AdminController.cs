using System;
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

        public ActionResult Table()
        {
            return View();
        }

        public ActionResult Notifications()
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

        public List<Armstrong> GetArmstrong(string search, string sort, string sortdir, int skip, int pageSize, out int totalRecord)
        {
            using (ArmstrongCinicDatabaseEntities2 dc = new ArmstrongCinicDatabaseEntities2())
            {
                var v = (from a in dc.Armstrongs
                         where
                                 a.SuccessRate.Contains(search)
                         select a
                         );
                totalRecord = v.Count();
                v = v.OrderBy(sort + " " + sortdir);
                if (pageSize > 0)
                {
                    v = v.Skip(skip).Take(pageSize);
                }
                return v.ToList();
            }
        }

    }
}