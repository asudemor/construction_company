using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace construction_company.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Team()
        {
            ViewBag.Message = "Takım Sayfasındasınız.";
            return View();
        }
    }
}