using InsuranceQuoteMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuoteMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, 
            string emailAddress, string dateOfBirth, int carYear, string carMake, 
            string carModel, string hadDUI, int numOfTickets, string coverageOption)
        {
            try
            {
                double quoteNum = 50;
                int userAge;

                //User has to enter birthday like this: month/day/year which will checked on the front end
                DateTime birthDate = DateTime.Parse(dateOfBirth);
                userAge = DateTime.Today.Year - birthDate.Year;

                if (userAge < 25)
                {
                    quoteNum += 25;
                }
                if (userAge < 18)
                {
                    quoteNum += 100;
                }
                if (userAge > 100)
                {
                    quoteNum += 25;
                }
                if (carYear < 2000)
                {
                    quoteNum += 25;
                }
                if (carYear > 2015)
                {
                    quoteNum += 25;
                }
                if (carMake.ToLower() == "porsche")
                {
                    quoteNum += 25;
                }
                if (carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera" || carModel.ToLower() == "911carrera")
                {
                    quoteNum += 25;
                }
                for (int i = 0; i < numOfTickets; i++)
                {
                    quoteNum += 10;
                }
                if (hadDUI.ToLower() == "yes")
                {
                    double oneFourth = quoteNum * 0.25;
                    quoteNum += oneFourth;
                }
                if (coverageOption.ToLower() == "full" || coverageOption.ToLower() == "full coverage")
                {
                    double half = quoteNum * 0.50;
                    quoteNum += half;
                }

                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var quote = new Quote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.MonthlyFee = (int)quoteNum;

                    db.Quotes.Add(quote);
                    db.SaveChanges();
                }

                return View("Success");

            }
            catch(Exception ex)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}