using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiaiptBac1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Timx()
        {
            return View();
        }
        public ActionResult Timx(string soA, string soB)
        {
            double so1 = Convert.ToDouble;
            double so2 = Convert.ToDouble;
            double gtx = so2 / so1;
            ViewBag.timgtx = gtx;
            return View();
        }
    }
}