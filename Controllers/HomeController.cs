using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Chandan_Rajendra.Models;
using CV_Chandan_Rajendra.Controllers;

namespace CV_Chandan_Rajendra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var skill1 = SkillsController.all_skills();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Skills()
        {
            

            return View();    
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult work_experience()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Languages()
        {
            return View();
        }
    }
}