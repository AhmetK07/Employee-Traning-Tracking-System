using _5001ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5001ProjectNew.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(_5001ProjectNew.Models.WebRegister webRegister)
        {
            using (TrainingTrackingEntities db = new TrainingTrackingEntities())
            {
                var userDetails = db.WebRegisters.Where(x => x.Id == webRegister.Id && x.Password == webRegister.Password).FirstOrDefault();
                if(userDetails ==null)
                {
                    webRegister.LoginErrorMessage = "Wrong UserId or Password";
                    return View("Login", webRegister);
                }
                else
                {
                    Session["UserId"] = userDetails.Id;
                    Session["FirstName"] = userDetails.FirstName;
                    Session["LastName"] = userDetails.LastName;
                    Session["Email"] = userDetails.Email;
                    Session["Telephone"] = userDetails.Telephone;
                    Session["Professiontitle"] = userDetails.Professiontitle;
                    Session["TrainingCourse"] = userDetails.TrainingCourse;
                    return RedirectToAction("UserProfile", "Home");
                }
            }
            
        }

        public ActionResult LogOut()
        {
            int Id = (int)Session["UserId"];
            Session.Abandon();
            return RedirectToAction("Login","Login");
        }

    }
}