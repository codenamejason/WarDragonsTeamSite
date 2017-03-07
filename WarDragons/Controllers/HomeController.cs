using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarDragons.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Eightballers WIKI";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Eightballers description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Eightballers contact page.";

            return View();
        }
    }
}