using AccountDetails.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AccountDetails.Controllers
{
    public class AccountDetailsController : Controller
    {
        private accountdetailsEntities db = new accountdetailsEntities();
        // GET: AccountDetails
        
        public ActionResult AccountDetails()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddAccountDetails(accdetails model)

        {
            if (ModelState.IsValid)
            {
                accdetails obj = new accdetails();
                obj.FirstName = model.FirstName;
                obj.LastName = model.LastName;
                obj.AccountNumber = model.AccountNumber;
                obj.PAN = model.PAN;
                obj.BankName = model.BankName;
                obj.IFSC = model.IFSC;
                obj.AccountType = model.AccountType;

                dbObj.accdetails.Add(obj);
                dbObj.saveChanges();
            }
            ModelState.Clear();
                return View();
        }

    }
}