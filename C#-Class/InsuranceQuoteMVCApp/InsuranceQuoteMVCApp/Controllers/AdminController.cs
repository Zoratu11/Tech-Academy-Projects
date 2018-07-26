using InsuranceQuoteMVCApp.Models;
using InsuranceQuoteMVCApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuoteMVCApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quoteVMs = new List<QuoteVM>();
                foreach(var quote in db.Quotes)
                {
                    var quoteVM = new QuoteVM();
                    quoteVM.Id = quote.Id;
                    quoteVM.FirstName = quote.FirstName;
                    quoteVM.LastName = quote.LastName;
                    quoteVM.EmailAddress = quote.EmailAddress;
                    quoteVM.MonthlyFee = (int)quote.MonthlyFee;
                    quoteVMs.Add(quoteVM);
                }
                return View(quoteVMs);
            }
        }
    }
}