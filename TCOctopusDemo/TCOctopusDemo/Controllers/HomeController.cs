using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;

namespace TCOctopusDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string name = WebConfigurationManager.AppSettings["ApplicationName"];
            ViewBag.Message = String.Format("{0} TeamCity + Octopus Demo.", name);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View()
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
