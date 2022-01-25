using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BankProject.Models;

namespace BankProject.Controllers
{
    public class CustomersDetailsController : Controller
    {
        private viewCustomerDBEntities db = new viewCustomerDBEntities();

        // GET: CustomersDetails
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: CustomersDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: CustomersDetails/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: CustomersDetails/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create([Bind(Include = "ID,Name,Email,Phone,Address,City,PanCardNo,AdharNumber,DOB")] Customer customer)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Customers.Add(customer);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        return View(customer);
        //    }

        //    // GET: CustomersDetails/Edit/5
        //    public ActionResult Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Customer customer = db.Customers.Find(id);
        //        if (customer == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(customer);
        //    }

        //    // POST: CustomersDetails/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit([Bind(Include = "ID,Name,Email,Phone,Address,City,PanCardNo,AdharNumber,DOB")] Customer customer)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Entry(customer).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(customer);
        //    }

        //    // GET: CustomersDetails/Delete/5
        //    public ActionResult Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Customer customer = db.Customers.Find(id);
        //        if (customer == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(customer);
        //    }

        //    // POST: CustomersDetails/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult DeleteConfirmed(int id)
        //    {
        //        Customer customer = db.Customers.Find(id);
        //        db.Customers.Remove(customer);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
        //}
    }
}
