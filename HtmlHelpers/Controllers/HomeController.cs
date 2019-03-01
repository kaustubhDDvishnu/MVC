using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        mvcStudentModelContainer entities = new mvcStudentModelContainer();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StuHome()
        {

            return View();
        }
        public ActionResult StuContact()
        {
            return View();
        }
        public ActionResult StuClass()
        {
            return View();
        }
        public ActionResult StuTraining()
        {
            return View();
        }
    }
}