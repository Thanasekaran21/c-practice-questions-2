using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_9
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

            if (a < b && b < c)
            {
                Console.WriteLine("a is the smallest");
            }
            else if (a > b && b < c)
            {
                Console.WriteLine("b is the smallest");
            }

            else if (a > b && b > c)
            {
                Console.WriteLine("c is the smallest");
            }
        }

    }
}
