using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_type_operator_control_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logicaloperator();
            //Arithmeticoperator();
            //BitwiseOperator();
           // RelationalOperator();
            Person manish= new Person();
            manish.numberofEyes = 2;
            manish.hairColor = "black";
            Console.WriteLine("You have " + manish.numberofEyes + " eyes");
            Console.WriteLine("You hair color is " + manish.hairColor);
            manish.EatingHabit();
            manish.EatingHabit("momo");
            string mylunch = manish.eatingHabit("biryani");
            Console.WriteLine(mylunch);
            Console.ReadKey();
        }
        // This function is example of Logical Operator
        static void Logicaloperator()
        {
            Console.WriteLine("Enter your college name");
            string collegeName=Console.ReadLine();
            Console.WriteLine("Enter your program");
            string programName=Console.ReadLine();
            if(collegeName.ToUpper() =="BMC" && programName.ToUpper() == "CSIT")
            {
                Console.WriteLine("You are welcome in Lab");
            }
            else
            {
                Console.WriteLine("You arenot allowed to enter");
            }
        }
        // This function is example of Arithmetic Operator
        static void Arithmeticoperator()
        {
            Console.WriteLine("Enter the first number");
            string firstNumber= Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string secondNumber = Console.ReadLine();
            int sum= Convert.ToInt32(firstNumber)+ Convert.ToInt32(secondNumber);
            int sub= Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber);
            int mult= Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber);
            int div = Convert.ToInt32 (firstNumber)/ Convert.ToInt32(secondNumber);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
        // This function is example of Bitwise Operator
        static void BitwiseOperator()
        {
            Console.WriteLine("Enter the first number");
            string firstNumber= Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string secondNumber= Console.ReadLine();
            int bitwiseOR = Convert.ToInt32(firstNumber) | Convert.ToInt32(secondNumber);
            Console.WriteLine(bitwiseOR);
        }
        
        static void RelationalOperator()
        {
            Console.WriteLine("Enter your First number");
            string firstNumber= Console.ReadLine();
            Console.WriteLine("Enter your Second number");
            string secondNumber= Console.ReadLine();
            Console.Write("The greater number is ");
            if (Convert.ToInt32(firstNumber) > Convert.ToInt32(secondNumber))
            {
                
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
                }
    }
}
