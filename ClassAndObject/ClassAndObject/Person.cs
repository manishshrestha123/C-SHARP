using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Person
    {
        int numberOfEyes;
        public int noOfEyes
        {
            get { return numberOfEyes; }
            set
            {
                numberOfEyes =
       value;
            }
        }
        public string hairColor { get; set; }
        public void EatingHabit()
        {
            Console.WriteLine("I usually have Mo:Mo in lunch");
        }
        public void EatingHabit(string myLunch)
        {
            Console.WriteLine("I usually have " + myLunch + "in lunch.");
        }
        public string EatHabit(string Lunch)
        {
            return Lunch;
        }

    }
}
