using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Application.Service.Entities.Models;
using AIM.Web.Application.JobServiceReference;

namespace AIM.Web.Application.Controllers
{
    public class OpenJobController : Controller
    {
        private readonly JobServiceClient _jobClient = new JobServiceClient();

        // GET: /OpenJob/
        [HttpPost]
        public ActionResult Index(string region)
        {
            ViewBag.Message = region;

            var jobs = _jobClient.GetOpenJobsList(region);
            return View(jobs.ToList());
        }

        
        /*
        // GET: /OpenJob/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = _jobClient.OpenJob(id); //TODO
            if (openjob == null)
            {
                return HttpNotFound();
            }
            return View(openjob);
        }
        */
       
    }
}
