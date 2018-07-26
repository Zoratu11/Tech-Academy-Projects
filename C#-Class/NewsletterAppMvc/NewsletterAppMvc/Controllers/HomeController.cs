using NewsletterAppMvc.Models;
using NewsletterAppMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) )
            {
                return View("~/Views/Shared/Error.cshtml");
            } else
            {
                using(NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUps1();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps1.Add(signup);
                    db.SaveChanges();
                }

                return View("Success");
            }
        }
    }
}