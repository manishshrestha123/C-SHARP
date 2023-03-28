using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_type_operator_control_statement
{
    internal class Person
    {
       public int numberofEyes;
       public int noofEyes { get { return numberofEyes; } set { numberofEyes = value; } }
       public  string hairColor { get; set; }
       
        public void EatingHabit()
        {
            Console.WriteLine("I usually have chowmein in lunch");
        }
        public void EatingHabit(string myLunch)
        {
            Console.WriteLine("I usually have " + myLunch + " in lunch");
        }
        public string eatingHabit(string mylunch)
        {
            return "I usually have" + mylunch+ "in my lunch";
        }
    }
}
