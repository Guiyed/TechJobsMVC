using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Dictionary<string, string>> JobsList = new List<Dictionary<string, string>>();
            ViewBag.columns = ListController.columnChoices;            
            
            if (searchType == "all")
            {
                ViewBag.title = ((searchTerm == null) ? "All the Jobs" : "Jobs with the keyword: " + searchTerm);
                //JobsList = JobData.FindByValue((searchTerm == null) ? "": searchTerm);
                JobsList = JobData.FindByValue(searchTerm?? "");
            }
            else
            {
                ViewBag.title = "Jobs with " + searchType + ": " + searchTerm;
                JobsList = JobData.FindByColumnAndValue(searchType, searchTerm);
            }            
            ViewBag.jobs = JobsList;
            ViewBag.searchTerm = searchTerm;
            ViewBag.selected = searchType;
            return View("Index");

        }

    }
            
}
