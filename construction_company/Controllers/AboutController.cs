﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace construction_company.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            ViewBag.Message = "Hakkımızda Sayfasındasınız.";

            return View();
        }

    }
}