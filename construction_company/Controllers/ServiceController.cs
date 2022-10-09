using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace construction_company.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Service()
        {
            ViewBag.Message = "Hizmetler Sayfasındasınız.";

            return View();
        }
    }
}