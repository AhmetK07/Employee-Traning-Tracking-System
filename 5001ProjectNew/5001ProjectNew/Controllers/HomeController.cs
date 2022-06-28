using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5001ProjectNew.Models;

namespace _5001ProjectNew.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult RegisterCourses()
        {
            using (TrainingTrackingEntities db = new TrainingTrackingEntities())
            {
                return View(db.WebRegisters.ToList());
            }
            
        }

       
        public ActionResult Edit(int id)
        {
            using (TrainingTrackingEntities db = new TrainingTrackingEntities())
            {
                return View(db.WebRegisters.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, WebRegister webRegister)
        {
            
            
                using (TrainingTrackingEntities db = new TrainingTrackingEntities())
                {
                    db.Entry(webRegister).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("RegisterCourses");
             
        }

    }
}