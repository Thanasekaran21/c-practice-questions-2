using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_23
{
    class Program
    {
        class MyProgram
        {
            static void roots(double a, double b, double c)
            {
                //doubt

                double D = b * b - 4 * a * c;
                if (D >= 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Roots are: " + x1 + ", " + x2);
                }
                else
                {
                    double x1 = -b / (2 * a);
                    double x2 = Math.Sqrt(-D) / (2 * a);
                    Console.WriteLine("Roots are: " + x1 + "±" + x2 + "i");
                }
            }

            static void Main(String[] args)
            {
                Console.WriteLine("Equation is x*x+5x+4=0");
                roots(1, 5, 4);
                Console.WriteLine("\nEquation is x*x+4x+5=0");
                roots(1, 4, 5);
            }
        }
    }
}
