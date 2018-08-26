using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;

namespace AspDotNetCoaching.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            Logger.Info("This is a log.");

            var aNumber = int.Parse("abc");

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
    }
}