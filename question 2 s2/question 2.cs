using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2_s2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            int number2 = int.Parse(Console.ReadLine());

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

