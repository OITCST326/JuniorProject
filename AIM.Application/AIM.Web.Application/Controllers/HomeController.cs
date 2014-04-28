using AIM.Application.Service.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIM.Web.Application.Controllers
{
    public class HomeController : Controller
    {
        private AIM_DBContext db = new AIM_DBContext();

        public ActionResult Index()
        {
            //ViewBag.DropDownValues = db.Stores.ToList();
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