using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Service.Entities.Models;

namespace AIM.Web.Admin.Controllers
{
    public class Default1Controller : Controller
    {
        private AIM_DBContext db = new AIM_DBContext();

        // GET: /Default1/
        public ActionResult Index()
        {
            var jobs = db.Jobs.Include(j => j.Hour).Include(j => j.InterviewQuestion).Include(j => j.Questionnaire);
            return View(jobs.ToList());
        }

        // GET: /Default1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: /Default1/Create
        public ActionResult Create()
        {
            ViewBag.hoursId = new SelectList(db.Hours, "hoursId", "hoursId");
            ViewBag.InterviewquestionId = new SelectList(db.InterviewQuestions, "interviewQuestionsId", "interviewQuestionsId");
            ViewBag.questionnaireId = new SelectList(db.Questionnaires, "questionnaireId", "questionnaireId");
            return View();
        }

        // POST: /Default1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="jobId,position,description,fullPartTime,salaryRange,questionnaireId,hoursId,InterviewquestionId")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.hoursId = new SelectList(db.Hours, "hoursId", "hoursId", job.hoursId);
            ViewBag.InterviewquestionId = new SelectList(db.InterviewQuestions, "interviewQuestionsId", "interviewQuestionsId", job.InterviewquestionId);
            ViewBag.questionnaireId = new SelectList(db.Questionnaires, "questionnaireId", "questionnaireId", job.questionnaireId);
            return View(job);
        }

        // GET: /Default1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            ViewBag.hoursId = new SelectList(db.Hours, "hoursId", "hoursId", job.hoursId);
            ViewBag.InterviewquestionId = new SelectList(db.InterviewQuestions, "interviewQuestionsId", "interviewQuestionsId", job.InterviewquestionId);
            ViewBag.questionnaireId = new SelectList(db.Questionnaires, "questionnaireId", "questionnaireId", job.questionnaireId);
            return View(job);
        }

        // POST: /Default1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="jobId,position,description,fullPartTime,salaryRange,questionnaireId,hoursId,InterviewquestionId")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.hoursId = new SelectList(db.Hours, "hoursId", "hoursId", job.hoursId);
            ViewBag.InterviewquestionId = new SelectList(db.InterviewQuestions, "interviewQuestionsId", "interviewQuestionsId", job.InterviewquestionId);
            ViewBag.questionnaireId = new SelectList(db.Questionnaires, "questionnaireId", "questionnaireId", job.questionnaireId);
            return View(job);
        }

        // GET: /Default1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: /Default1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
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
    }
}
