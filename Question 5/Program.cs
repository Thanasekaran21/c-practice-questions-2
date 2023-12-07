using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(" This is a leap year");

            }
            else
            {
                Console.WriteLine("this is not a leap year");
            }
        }
    }
}
