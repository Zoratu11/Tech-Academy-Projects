using NewsletterAppMvc.Models;
using NewsletterAppMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signups = db.SignUps1.Where(x => x.Removed == null);
                var signups = (from c in db.SignUps1
                               where c.Removed == null
                               select c).ToList();
                var signupVms = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignUpVM();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }

        [HttpPost]
        public ActionResult Unsubscribe(int Id)
        {
            using(NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps1.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}