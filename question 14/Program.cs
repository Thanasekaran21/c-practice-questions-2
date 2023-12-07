using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter side1");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter side2");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter side3");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("yes you can form");

            }

            else 

            {
                Console.WriteLine("you can't form a triangle");


            }

            }

        }
    }

