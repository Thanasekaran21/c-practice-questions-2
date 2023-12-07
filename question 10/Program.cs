using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num3:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num4:");
            int num4 = int.Parse(Console.ReadLine());


            if (num1 < num2 && num2 < num3 && num3 < num4)
            {
                Console.WriteLine("num4 is the largest");

            }

            else if (num1 < num2 && num2 > num3 && num3 > num4)
            {
                Console.WriteLine("num2 is the largest");
            }

            else if (num1 < num2 && num2 < num3 && num3 > num4)
            {
                Console.WriteLine("num3 is the largest");

            }

            else if (num1 > num2 && num2 > num3 && num3 > num4)
            {
                Console.WriteLine("num1 is the largest");

            }

            else
            {
                Console.WriteLine("invalid");


            }
        }
    }
}
