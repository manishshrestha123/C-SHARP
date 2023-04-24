using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        IDataService _service;
        public HomeController(IDataService dataservice)
        {
            _service = dataservice;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GetDate()
        {
            // IDataService dt = new DataService();
            //return Content(dt.GetData().ToString());
            return Content(_service.GetData());
           // return Content("Trying to another string");
        }
    }
}