using System;
using System.Linq;
namespace GroupByLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var StudentGroup =  from student in Student.GetDetail()
                                group student by student.Faculty;
            //var StudentGroup = Student.GetDetail().GroupBy(x=>x.Faculty);

            Console.WriteLine("The count of the student which lastname is Shrestha according to faculty");

            foreach(var group in StudentGroup)
            {
                Console.WriteLine("{0} = {1}", group.Key, group.Count(x =>x.LastName == "Shrestha"));
            }
            Console.WriteLine("The maximum age of student in respective faculty:");
            foreach (var group in StudentGroup)
            {
                Console.WriteLine("{0} = {1}", group.Key, group.Max(x => x.Age));
            }
            
            //Select
            List<Student> students = Student.GetDetail();
            IEnumerable<string> Name = students.Select(x => x.FirstName).ToList();
            foreach (var student in Name)
            {
                Console.WriteLine(student);
            }
            // SelectMany 
            //To Write all the letter on first name which doesnot repeat
            var allCourses = students.SelectMany(student => student.FirstName).Distinct();

            foreach (var course in allCourses)
            {
                Console.WriteLine(course);
            }

        }
    }
}
