using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBlog2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Message = "Specific Blog page.";

            return View();
        }
        public ActionResult Details1()
        {
            ViewBag.Message = "Specific Blog page.";

            return View();
        }
    }
}