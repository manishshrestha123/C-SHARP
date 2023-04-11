using System;
namespace Abstract_Class
{
    public abstract class person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string ContactNumber;
        public abstract void PrintDetails();
    }
    class student : person
    {
        public int RollNo;
        public int Fees;
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Age of Student: " + this.Age);
            Console.WriteLine("Contact Number of Student: " +
            this.ContactNumber);
            Console.WriteLine("Student Roll Number: " + this.RollNo);
            Console.WriteLine("Student Fees: " + this.Fees);
        }
    }
    class professor : person
    {
        public string Qualification;
        public int Salary;
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Professor's Name: " + name);
            Console.WriteLine("Professor's Age: " + this.Age);
            Console.WriteLine("Professor's Contact Number: " +
            this.ContactNumber);
            Console.WriteLine("Qualification: " + this.Qualification);
            Console.WriteLine("Salary: " + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student Manish = new student();
            Manish.FirstName = "Manish";
            Manish.LastName = "Shrestha";
            Manish.Age = 21;
            Manish.ContactNumber = "98132114212";
            Manish.RollNo = 14;
            Manish.Fees = 75000;
            Manish.PrintDetails();
            Console.WriteLine("------------------------------");
            professor Riya = new professor();
            Riya.FirstName = "Riya";
            Riya.LastName = "Shrestha";
            Riya.Age = 32;
            Riya.ContactNumber = "9824234534";
            Riya.Qualification = "M.E Civil";
            Riya.Salary = 5000000;
            Riya.PrintDetails();
            Console.ReadKey();
        }
    }
}