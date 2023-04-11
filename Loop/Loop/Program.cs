using System;
namespace Loops
{
    internal class Program
    {
        //For loop to print first four numbers
        static void forLoop()
        {
            int i = 1;
            for (; i <= 4;)
            {
                Console.WriteLine(i);
                i++;

            }
        }
        //for each loop to print all the elements of an array
        static void foreachloop()
        {
            string[] country = { "Nepal", "Malaysia", "Bhutan", "USA" };
            foreach (string x in country)
            {
                Console.Write(x + "\t");
            }
        }
        //while loop to print from 1 to 4
        static void whileLoop()
        {
            int i = 1;
            while (i <= 4)
            {
                Console.Write(i + "\t");
                i++;
            }
        }
        //do- while loop to print from 1 to 4
        static void doWhileLoop()
        {
            int x = 0;
            do
            {
                Console.Write("x= " + x + "\t");
                x++;
            } while (x <= 4);
        }
        static void Main(string[] args)
        {
            //forLoop();
            //foreachloop();
            //whileLoop();
            doWhileLoop();
            Console.ReadKey();
        }
    }
}