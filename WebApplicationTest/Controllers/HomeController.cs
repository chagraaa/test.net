﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        // random comment
        public ActionResult Index()
        {
            return View(); //;missing
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your Orange contact page.";

            return View();
        }
    }
}