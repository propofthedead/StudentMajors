using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentMajors.Models;

namespace StudentMajors.Controllers
{
    public class EnrolledsController : Controller
    {
        private SchoolDataContext db = new SchoolDataContext();

        // GET: Enrolleds
        public ActionResult Index()
        {
            return View(db.Enrolleds.ToList());
        }

        // GET: Enrolleds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrolled enrolled = db.Enrolleds.Find(id);
            if (enrolled == null)
            {
                return HttpNotFound();
            }
            return View(enrolled);
        }

        // GET: Enrolleds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enrolleds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,ClassId,Grade")] Enrolled enrolled)
        {
            if (ModelState.IsValid)
            {
                db.Enrolleds.Add(enrolled);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enrolled);
        }

        // GET: Enrolleds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrolled enrolled = db.Enrolleds.Find(id);
            if (enrolled == null)
            {
                return HttpNotFound();
            }
            return View(enrolled);
        }

        // POST: Enrolleds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,ClassId,Grade")] Enrolled enrolled)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrolled).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enrolled);
        }

        // GET: Enrolleds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrolled enrolled = db.Enrolleds.Find(id);
            if (enrolled == null)
            {
                return HttpNotFound();
            }
            return View(enrolled);
        }

        // POST: Enrolleds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrolled enrolled = db.Enrolleds.Find(id);
            db.Enrolleds.Remove(enrolled);
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
