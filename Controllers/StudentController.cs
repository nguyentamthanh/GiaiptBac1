using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiaiptBac1.Models;

namespace GiaiptBac1.Controllers
{
    public class StudentController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();

        // GET: Student
        public ActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);
        }
       
    }
}