using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Customer_Transactional_Details_Test.Models;

namespace Customer_Transactional_Details_Test.Controllers
{
    public class TDModelsController : Controller
    {
        private TDModelContext db = new TDModelContext();

        // GET: TDModels
        public ActionResult Index()
        {
            return View(db.TDModel.ToList());
        }

        // GET: TDModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDModel tDModel = db.TDModel.Find(id);
            if (tDModel == null)
            {
                return HttpNotFound();
            }
            return View(tDModel);
        }

        // GET: TDModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TNo,Transactional_Details,Credit,Debit,Date")] TDModel tDModel)
        {
            if (ModelState.IsValid)
            {
                db.TDModel.Add(tDModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tDModel);
        }

        // GET: TDModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDModel tDModel = db.TDModel.Find(id);
            if (tDModel == null)
            {
                return HttpNotFound();
            }
            return View(tDModel);
        }

        // POST: TDModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TNo,Transactional_Details,Credit,Debit,Date")] TDModel tDModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tDModel);
        }

        // GET: TDModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDModel tDModel = db.TDModel.Find(id);
            if (tDModel == null)
            {
                return HttpNotFound();
            }
            return View(tDModel);
        }

        // POST: TDModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TDModel tDModel = db.TDModel.Find(id);
            db.TDModel.Remove(tDModel);
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
