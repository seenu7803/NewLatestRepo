﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult FirstView()
        {
            return View();
        }
        public ActionResult SecondView()
        {
            return View();
        }
        public ActionResult ThirdView()
        {
            return View();
        }
        public ActionResult FourthView()
        {
            return View();
        }
        //New Change
    }
}