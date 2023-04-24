using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;

namespace WebApi.Controllers
{
    public class StudentInfoController : Controller
    {
        public IActionResult AddStudent()
        {
            StudentInfoModel manish = new StudentInfoModel();

            return View();

        }
        [HttpPost]
        public IActionResult AddStudent(StudentInfoModel std)
        {
            //Connection String
            string ConnectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=BMC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Command ="Insert Into StudentInfo VALUES('Bishwo', 'NCC', 20)";
            SqlCommand cmd = new SqlCommand(Command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();


        }
    }
}
