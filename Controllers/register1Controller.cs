using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Register_and_login.Models;

namespace Register_and_login.Controllers
{
    public class register1Controller : Controller
    {
        private userinputEntities db = new userinputEntities();

        // GET: register1
        public ActionResult Index()
        {
            return View(db.register1.ToList());
        }

        // GET: register1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            register1 register1 = db.register1.Find(id);
            if (register1 == null)
            {
                return HttpNotFound();
            }
            return View(register1);
        }

        // GET: register1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: register1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "studentid,studntfname,studentlname,studentdept,stumobilenumber")] register1 register1)
        {
            if (ModelState.IsValid)
            {
                db.register1.Add(register1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(register1);
        }

        // GET: register1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            register1 register1 = db.register1.Find(id);
            if (register1 == null)
            {
                return HttpNotFound();
            }
            return View(register1);
        }

        // POST: register1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "studentid,studntfname,studentlname,studentdept,stumobilenumber")] register1 register1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(register1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(register1);
        }

        // GET: register1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            register1 register1 = db.register1.Find(id);
            if (register1 == null)
            {
                return HttpNotFound();
            }
            return View(register1);
        }

        // POST: register1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            register1 register1 = db.register1.Find(id);
            db.register1.Remove(register1);
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
