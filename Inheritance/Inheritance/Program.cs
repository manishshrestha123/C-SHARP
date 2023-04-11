using System;
namespace Inheritance
{
    class VisitingEmployees : Employees
    {
        public int VisitingSalary;
        public int VisitingHours;
    }
    class PermanentEmployees : Employees
    {
        public int PermanentSalary;
        public int PermanentHours;
    }
    class Employees
    {
        public int EmpID;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;
        public void show()
        {
            Console.WriteLine("This is a method of a parent (base) class.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployees Manish = new PermanentEmployees();
            Manish.EmpID = 7;
            Manish.show();
            VisitingEmployees Riya = new VisitingEmployees();
            Riya.EmpID = 27;
            Console.WriteLine("ID: " + Manish.EmpID);
            Console.WriteLine("ID: " + Riya.EmpID);
            Console.ReadKey();
        }
    }
}
