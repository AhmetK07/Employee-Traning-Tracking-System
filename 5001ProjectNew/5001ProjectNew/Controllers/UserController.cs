using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5001ProjectNew.Models;

namespace _5001ProjectNew.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            WebRegister webModel = new WebRegister();
            return View(webModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(WebRegister webModel)
        {
            using (TrainingTrackingEntities db = new TrainingTrackingEntities())
            {
                if (db.WebRegisters.Any(x => x.Email == webModel.Email))
                {
                    ViewBag.DuplicateMessage = "Account Already Exists";
                        return View("AddOrEdit", webModel);
                }
                db.WebRegisters.Add(webModel);
                db.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccesMessage = "Registeration Succesful";
            return View("AddOrEdit", new WebRegister());
        }

    }
}