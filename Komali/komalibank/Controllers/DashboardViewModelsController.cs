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
    public class DashboardViewModelsController : Controller
    { }
}
//        private KomaliBankContext db = new KomaliBankContext();

//        // GET: DashboardViewModels
//        public ActionResult Index()
//        {
//            return View(db.DashboardViewModels.ToList());
//        }

//        // GET: DashboardViewModels/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DashboardViewModel dashboardViewModel = db.DashboardViewModels.Find(id);
//            if (dashboardViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dashboardViewModel);
//        }

//        // GET: DashboardViewModels/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: DashboardViewModels/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "id")] DashboardViewModel dashboardViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.DashboardViewModels.Add(dashboardViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(dashboardViewModel);
//        }

//        // GET: DashboardViewModels/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DashboardViewModel dashboardViewModel = db.DashboardViewModels.Find(id);
//            if (dashboardViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dashboardViewModel);
//        }

//        // POST: DashboardViewModels/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "id")] DashboardViewModel dashboardViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(dashboardViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(dashboardViewModel);
//        }

//        // GET: DashboardViewModels/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DashboardViewModel dashboardViewModel = db.DashboardViewModels.Find(id);
//            if (dashboardViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dashboardViewModel);
//        }

//        // POST: DashboardViewModels/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            DashboardViewModel dashboardViewModel = db.DashboardViewModels.Find(id);
//            db.DashboardViewModels.Remove(dashboardViewModel);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
