using System;
namespace Destructor1
{
    class Person
    {
        public string Name;
        public int Age;
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }
        ~Person()
        {
            Console.WriteLine("Destructor has been invoked.");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person Manish = new Person("Manish", 21);
                Console.WriteLine("Name: " + Manish.getName());
                Console.WriteLine("Age: " + Manish.getAge());
                Console.ReadKey();
            }
        }
    }
}