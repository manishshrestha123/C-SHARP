using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void weekEnd()
            {
                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Today is Weekend.");
                        break;
                    default:
                        Console.WriteLine("Today is working day.");
                        break;
                }
            }
            weekEnd();
            Console.ReadKey();
        }
    }
}
