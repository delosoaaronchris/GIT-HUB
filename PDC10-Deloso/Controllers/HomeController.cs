using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDC10_Deloso.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /*       public ActionResult Contact()
               {
                   ViewBag.Message = "Your contact page.";

                   return View();
               }      
               public ActionResult MyProfile()
               {
                   ViewBag.Message = "This is My Profile Page";

                   return View();
               }
        */
        public ActionResult PhotoGallery()
        {
            ViewBag.Message = "This is My Profile Page";

            return View();
        }

    }
}