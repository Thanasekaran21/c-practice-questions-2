using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3_s2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            double  number2 = double.Parse(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine(" they are equal");

            }
            else if (number1 != number2)
            {

                Console.WriteLine("they are not equal");

            }

            else
            {
                Console.WriteLine("invalid input");


            }
        }
    }
}
