﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hairByMouth2.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Message = "my form";

            return View();
        }

        [HttpPost]
        public ActionResult Form(string friendsname, string yourname,
            string salonname, string stylistname)
        {
            

            return View();
        }

    }
}