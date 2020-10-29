using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getScreenResolution()
        {
            var ListScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListScreenResolution);
        }
        public ActionResult getTypeName()
        {
            var ListTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeName);
        }
        /// Sv tự thêm các thông tin khác 
    }
}