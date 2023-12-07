using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_13_s2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c");
            int c = int.Parse(Console.ReadLine());

            if (a > b && b > c && c < a)
            {
                Console.WriteLine("a,b,c");

            }

            else if (a > b && b < c && c < a)
            {
                Console.WriteLine("b,c,a");

            }

            else if (a < b && b < c && c > a)
            {
                Console.WriteLine("c,b,a");

            }

            else if (a > b && b < c && c > a)
            {
                Console.WriteLine("b,a,c");
            }

            else if (a < b && b > c && c > a)
            {
                Console.WriteLine("a,c,b");
            }
            else if (a < b && b > c && c < a)
            {
                Console.WriteLine("c,a,b");
            }
        }
    }
}
