using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Equilateral triangle");

            }

            else if (a == c && b < a)
            {
                Console.WriteLine("isosceles triangle");

            }

            else if (a<b && b>c && c>a)

            {
                Console.WriteLine("scalene triangle");

            }

        }

    }
}
