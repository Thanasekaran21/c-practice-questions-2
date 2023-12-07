using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter height of a : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter height of b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter height of c: ");
            int c = int.Parse(Console.ReadLine());

            if (a - b == b - c && c - a != a - b)
            {
                Console.WriteLine("a and b are closer");

            }
            else if (a - b == c - a && b - c != a - b)
            {
                Console.WriteLine("a and c are closer");

            }
            else if (b - c == c - a && a - b != b - c)
            {
                Console.WriteLine("b and c are closer");

            }

        }
    }
}
