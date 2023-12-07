using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter valuex");
            int valuex = int.Parse(Console.ReadLine());
            Console.WriteLine("enter valuey");
            int valuey = int.Parse(Console.ReadLine());



            if (valuex > 0  && valuey > 0)
            {
                Console.WriteLine("coordinate point lies in x,y ");

            }

            else if (valuex > 0 && valuey < 0)
            {
                Console.WriteLine("coordinate point lies in x,y1");

            }
            else if (valuex <  0 && valuey > 0)
            {
                Console.WriteLine("coordinate point lies in x1,y");

            }

            else if (valuex <0 && valuey < 0)
            {
                Console.WriteLine("coordinate point lies in x1,y1");

            }

            else if (valuex == 0 && valuey == 0)
            {
                Console.WriteLine("coordinate point liest in 0");
            }

            else if (valuex == 0)
            {
                Console.WriteLine("coordinate point lies in y");
            }

            else if (valuey == 0)
            {
                Console.WriteLine("coordinate point lies in x");
            }

        }
    }
}
