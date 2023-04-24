using Microsoft.AspNetCore.Mvc;

namespace FormWebApplication.Controllers
{
    public class CollegeController : Controller
    {
      
        public IActionResult College()
        {
            List<College> colleges = new List<College>();
            return View(colleges);
        }
        public IActionResult AddCollege()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateModel(College College)
    }
}
