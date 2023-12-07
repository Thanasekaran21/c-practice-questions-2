using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter marks");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine(" A grade");

            }

            else if (marks >= 80 && marks < 90)
            {
                Console.WriteLine("B grade");

            }

            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("C grade");
            }

            else if (marks >= 60 && marks < 70)
            {
                Console.WriteLine("D grade");

            }

            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("E grade");

            }
            else if (marks < 50)
            {
                Console.WriteLine("student fail");

            }

            else
            {
                Console.WriteLine("invalid output");

            }
        }
    }
}
