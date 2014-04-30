using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Application.Service.Entities.Models;
using System.Data.Entity.Core;
using AIM.Web.Application.JobServiceReference;

namespace AIM.Web.Application.Controllers
{
    public class OpenJobController : Controller
    {
        private readonly JobServiceClient _client = new JobServiceClient();

        // GET: /OpenJob/
        public ActionResult Index()
        {
            var openjobs = _client.GetOpenJobsList();
            return View(openjobs.ToList());
                    
        }
        
        /*
        // GET: /OpenJob/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = db.OpenJobs.Find(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }
            return View(openjob);
        }

        // GET: /OpenJob/Create
        public ActionResult Create()
        {
            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position");
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name");
            return View();
        }

        // POST: /OpenJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="openJobsId,jobId,storeId")] OpenJob openjob)
        {
            if (ModelState.IsValid)
            {
                db.OpenJobs.Add(openjob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position", openjob.jobId);
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name", openjob.storeId);
            return View(openjob);
        }

        // GET: /OpenJob/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = db.OpenJobs.Find(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }
            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position", openjob.jobId);
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name", openjob.storeId);
            return View(openjob);
        }

        // POST: /OpenJob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="openJobsId,jobId,storeId")] OpenJob openjob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(openjob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position", openjob.jobId);
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name", openjob.storeId);
            return View(openjob);
        }

        // GET: /OpenJob/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = db.OpenJobs.Find(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }
            return View(openjob);
        }

        // POST: /OpenJob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OpenJob openjob = db.OpenJobs.Find(id);
            db.OpenJobs.Remove(openjob);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
         * 
         * */
    }
         
}
