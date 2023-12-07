using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 31;


            if (number1 % 2 == 0)
            {
                Console.WriteLine("number is even");

            }
            else if (number1 % 2 != 0)
            {
                Console.WriteLine("number is odd");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
