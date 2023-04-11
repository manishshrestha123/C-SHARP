using Microsoft.AspNetCore.Mvc;

namespace Learning_WebApplication.Controllers
{
    public class BmcController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public PartialViewResult Home()
        {
            return PartialView("omes");
        }
        public ContentResult Content()
        {
            return Content("This is content return test");
        }
        public JsonResult json()
        {
            return Json(new { name = "manish", college = "bmc" });
        }
        public FileResult Download()
        {
            return File("myfiles/hello.txt", "text/plain", "myfile.txt");
        }
    }
}
