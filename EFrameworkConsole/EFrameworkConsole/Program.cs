using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace EFrameworkConsole
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1: Add New Student");
                    Console.WriteLine("2: Display All Students");
                    Console.WriteLine("3: Update a Student");
                    Console.WriteLine("4: Delete a Student");
                    Console.WriteLine("5: Remove all Student");
                    Console.WriteLine("6: Exit");

                    var option = Console.ReadLine();

                    switch (option)
                    {

                        case "1":
                            AddStudent();
                            break;
                        case "2":
                            DisplayStudents();
                            break;
                        case "3":
                            UpdateStudent();
                            break;
                        case "4":
                            DeleteStudent();
                            break;
                        case "5":
                            RemoveAllData();
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Invalid option, try again.");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void AddStudent()
        {
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Age");
            int age = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter Student Email");
            string email = Console.ReadLine();

            if (!EmailExists(email))
            {
                using (var context = new MyDbContext())
                {
                    var student = new Student { Name = name, Age = age, Email = email };
                    context.Students.Add(student);
                    context.SaveChanges();
                    Console.WriteLine("Student added successfully.");
                }
            }
            else
            {
                Console.WriteLine("Student not added due to duplicate email.");
            }
        }
        static void UpdateStudent()
        {
            Console.WriteLine("Enter Student ID:");
            int id = int.Parse(Console.ReadLine());

            using (var context = new MyDbContext())
            {
                var student = context.Students.FirstOrDefault(s => s.Id == id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.WriteLine("Enter new Name (leave blank to keep current):");
                string name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    student.Name = name;
                }

                Console.WriteLine("Enter new Age (leave blank to keep current):");
                string ageStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(ageStr))
                {
                    student.Age = int.Parse(ageStr);
                }

                Console.WriteLine("Enter new Email (leave blank to keep current):");
                string email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email))
                {
                    student.Email = email;
                }
                if (!EmailExists(email))
                {
                    context.SaveChanges();
                    Console.WriteLine("Student updated successfully.");
                }
                else
                {
                    Console.WriteLine("Student cannot added due to duplicate email");
                }
            }
        }
        static void DeleteStudent()
        {
            Console.WriteLine("Enter Student ID to delete:");
            int id = int.Parse(Console.ReadLine());

            using (var context = new MyDbContext())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                    Console.WriteLine("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
        }
        static void DisplayStudents()
        {
            using (var context = new MyDbContext())
            {
                var students = context.Students.ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
                }
            }
        }
        static void RemoveAllData()
        {
            
                using (var context = new MyDbContext())
                {
                    var allStudents = context.Students.ToList();
                    context.Students.RemoveRange(allStudents);
                    context.SaveChanges();
                    Console.WriteLine("All students have been removed.");
                }
            
        }
        static bool EmailExists(string email)
        {
            using (var context = new MyDbContext())
            {
                return context.Students.Any(s => s.Email == email);
            }
        }

    }


    public class MyDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-FRQ854E\SQLEXPRESS;
                                                          Initial Catalog=Manish;
                                                          Integrated Security=True;Encrypt=True;
                                                          Trust Server Certificate=True");
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

    }
}

 


