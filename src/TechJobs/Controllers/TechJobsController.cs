using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {
        internal static Dictionary<string, string> actionChoices = new Dictionary<string, string>();

        // This is a "static constructor" which can be used
        // to initialize static members of a class
        static TechJobsController()
        {
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");
        }


        IActionResult Index()
        {
            return View();
        }

        public override ViewResult View() {
            ViewBag.actions = actionChoices;
            return base.View();
        }

        public override ViewResult View(string viewName)
        {
            ViewBag.actions = actionChoices;
            return base.View();
        }


    }
}