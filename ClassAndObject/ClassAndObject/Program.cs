using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Manish = new Person();
            Manish.noOfEyes = 2;
            
            Manish.hairColor = "Black";
            Console.WriteLine("You have " + Manish.noOfEyes + " eyes.");
            Console.WriteLine("You have " + Manish.hairColor + " hair");
            Manish.EatingHabit();
            Manish.EatingHabit("Chowmein");
            Console.WriteLine("I also love eating " + Manish.EatHabit("Banana"));
            Console.ReadKey();

        }
}
}
