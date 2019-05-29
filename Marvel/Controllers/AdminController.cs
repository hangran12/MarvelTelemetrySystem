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

        public ActionResult ArmstrongClinicReport(int page = 1, string sort = "SuccessRate", string sortdir = "asc", string search = "")
        {
            int pageSize = 100;
            int totalRecord = 0;
            if (page < 1) page = 1;
            int skip = (page * pageSize) - pageSize;
            var data = GetArmstrong(search, sort, sortdir, skip, pageSize, out totalRecord);
            ViewBag.TotalRows = totalRecord;
            ViewBag.search = search;
            return View(data);
        }

        public ActionResult MarvelousClinicReport(int page = 1, string sort = "SuccessRate", string sortdir = "asc", string search = "")
        {
            int pageSize = 100;
            int totalRecord = 0;
            if (page < 1) page = 1;
            int skip = (page * pageSize) - pageSize;
            var data = GetMarvelous(search, sort, sortdir, skip, pageSize, out totalRecord);
            ViewBag.TotalRows = totalRecord;
            ViewBag.search = search;
            return View(data);
        }

        public ActionResult ClinicFReport(int page = 1, string sort = "SuccessRate", string sortdir = "asc", string search = "")
        {
            int pageSize = 100;
            int totalRecord = 0;
            if (page < 1) page = 1;
            int skip = (page * pageSize) - pageSize;
            var data = GetClinicF(search, sort, sortdir, skip, pageSize, out totalRecord);
            ViewBag.TotalRows = totalRecord;
            ViewBag.search = search;
            return View(data);
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

        public List<Marvelou> GetMarvelous(string search, string sort, string sortdir, int skip, int pageSize, out int totalRecord)
        {
            using (MarvelousClinicDatabaseEntities dc = new MarvelousClinicDatabaseEntities())
            {
                var v = (from a in dc.Marvelous
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

        public List<ClinicF> GetClinicF(string search, string sort, string sortdir, int skip, int pageSize, out int totalRecord)
        {
            using (ClinicFDatabaseEntities dc = new ClinicFDatabaseEntities())
            {
                var v = (from a in dc.ClinicFs
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