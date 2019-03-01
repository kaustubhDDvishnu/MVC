using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class DataPassController : Controller
    {
        // GET: DataPass
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Viewdd()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewData["Student"] = Student;
            return View();
        }

        public ActionResult Viewbb()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewBag.Student = Student;
            return View();
        }
        public ActionResult Viewtt()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            TempData["Student"] = Student;
            return View();
            //return this.RedirectToAction("StuHome","Home");
        }
    }
}