using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookingCurator.Controllers
{
    public class SettingController : Controller
    {
        // GET: Setting
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Change Username";
            ViewBag.Head = "Change Username";
            ViewBag.Username = "DoubleHamage";

            return View();
        }
    }
}