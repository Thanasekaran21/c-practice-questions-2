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
            Console.WriteLine("a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter d:");
            int d = int.Parse(Console.ReadLine());

int largest = d;


            if (a > largest)
            {

                largest = a;

            }
            if (b > largest)
            {

                largest = b;
            }
            if (c > largest)
            {
                largest = c;

            }

            Console.WriteLine(largest);


            


            }
        }
    }

