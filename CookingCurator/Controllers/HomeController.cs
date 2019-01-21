using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookingCurator.Controllers
{
    public class HomeController : Controller
    {
        // Reference to the data manager
        private Manager m = new Manager();

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

        public ActionResult Test()
        {
            ViewBag.Username = "Test";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Settings";
            ViewBag.Username = "Test";

            return View();
        }

        public ActionResult RecipeTemplate()
        {
            ViewBag.Message = "Recipe Page";
            ViewBag.Username = "Test";

            return View();
        }

        public ActionResult Diets()
        {
            ViewBag.Username = "Test";

            return View();
        }

        public ActionResult SortPreference()
        {
            ViewBag.Username = "Test";

            return View();
        }
    }
}