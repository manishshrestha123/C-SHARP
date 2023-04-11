using System;
namespace Indexers_in_CSharp
{
    class Employee
    {
        int[] Age = new int[3];
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value !");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index!!");
                }
            }
            get
            {
                return Age[index];
            }

        }
        public int this[int index, int i]
        {
            set
            {
                Age[index] = value + i;
            }
            get
            {
                return Age[index];
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[2] = 5;
            emp[1, 4] = 5;
            Console.WriteLine(emp[0]);
            Console.ReadKey();
        }
    }
}
