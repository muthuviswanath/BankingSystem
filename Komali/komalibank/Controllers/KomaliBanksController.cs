using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using komalibank.Models;

namespace komalibank.Controllers
{
    public class KomaliBanksController : Controller
    {
        private KomaliBankContext db = new KomaliBankContext();

        // GET: KomaliBanks
        public ActionResult Index()
        {
            return View(db.KomaliBank.ToList());
        }

        // GET: KomaliBanks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KomaliBank komaliBank = db.KomaliBank.Find(id);
            if (komaliBank == null)
            {
                return HttpNotFound();
            }
            return View(komaliBank);
        }

        // GET: KomaliBanks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KomaliBanks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,username,password")] KomaliBank komaliBank)
        {
            if (ModelState.IsValid)
            {
                db.KomaliBank.Add(komaliBank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(komaliBank);
        }

        // GET: KomaliBanks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KomaliBank komaliBank = db.KomaliBank.Find(id);
            if (komaliBank == null)
            {
                return HttpNotFound();
            }
            return View(komaliBank);
        }

        // POST: KomaliBanks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,username,password")] KomaliBank komaliBank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(komaliBank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(komaliBank);
        }

        // GET: KomaliBanks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KomaliBank komaliBank = db.KomaliBank.Find(id);
            if (komaliBank == null)
            {
                return HttpNotFound();
            }
            return View(komaliBank);
        }

        // POST: KomaliBanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KomaliBank komaliBank = db.KomaliBank.Find(id);
            db.KomaliBank.Remove(komaliBank);
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
