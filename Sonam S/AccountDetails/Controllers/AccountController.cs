using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountDetails.Controllers
{
    public class AccountController : Controller
    {
        AccountContext db = new AccountContext();


        public ActionResult Index()

        {
            return View(db.Account.ToList());
        }

        [HttpGet]
        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Account account)

        {
            if (ModelState.IsValid)
            {
                db.Account.Add(account);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(account);
        }




    }
}