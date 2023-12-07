using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1_s2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("number is positive");

            }

            else if (number < 0)
            {
                Console.WriteLine("number is negative");
            }

            else if (number == 0)
            {
                Console.WriteLine("number is 0");

            }
            else
            {
                Console.WriteLine("enter correct number");
            }

        }
    }
}
