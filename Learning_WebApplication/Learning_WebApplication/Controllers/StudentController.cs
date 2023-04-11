using Learning_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace Learning_WebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult StudentDetail()
        {
            StudentModel manish = new StudentModel();
            manish.FirstName = "Manish";
            manish.LastName = "Shrestha";
            manish.Address = "Dadhikot";
            manish.Age = 21;
            manish.CollegeName = "BMC";
            return View(manish);
        }
        public IActionResult Students()
        {
            StudentModel manish = new StudentModel();
            manish.FirstName = "Manish";
            manish.LastName = "Shrestha";
            manish.Address = "Dadhikot";
            manish.Age = 21;
            manish.CollegeName = "BMC";
            StudentModel riya = new StudentModel();
            riya.FirstName = "Riya";
            riya.LastName = "Shrestha";
            riya.Address = "Balkot";
            riya.Age = 20;
            riya.CollegeName = "Khwopa";
            List<StudentModel> Students = new List<StudentModel>();
            Students.Add(manish);
            Students.Add(riya); 
            return View(Students);

        }    }
}
