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
        JobServiceClient _jobClient = new JobServiceClient();

        public ActionResult Index()
        {
            var regions = _jobClient.GetRegionList();

            List<SelectListItem> items = new List<SelectListItem>();

            foreach(var item in regions)
            {
                items.Add(new SelectListItem { Text = item.regionName, Value = item.regionId.ToString() });
            }

            ViewBag.RegionList = regions.ToList();
            return View(regions.ToList());
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