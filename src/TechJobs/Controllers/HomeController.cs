using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class HomeController : TechJobsController
    //public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //This is the Info When Not Using Override (extends : Controller)
            /*
             * Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");
            
            ViewBag.actions = actionChoices;
            */

            return View();
        }
    }
}
