using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIM.Web.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly AIM.Web.Application.JobServiceReference.JobServiceClient _client = new AIM.Web.Application.JobServiceReference.JobServiceClient();


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

        public ActionResult ViewJobList()
        {
            var jobs = _client.GetJobsList();
            return View(jobs.ToList());
        }
    }
}