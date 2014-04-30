using AIM.Application.Service.Entities.Models;
using AIM.Web.Application.JobServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIM.Web.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly JobServiceClient _client = new JobServiceClient();

        public ActionResult Index()
        {
            return View();
            //var stores = _client.GetStoreList();
            //return View(stores);
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