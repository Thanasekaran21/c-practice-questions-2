using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter day of month");
            int day = int.Parse(Console.ReadLine());

        

            if (day == 1 || day == 8 || day == 15 || day == 22 || day == 29)

            {
                Console.WriteLine("monday");
            }

            else if (day == 2 || day == 9 || day == 16 || day == 23 || day == 30)
            {
                Console.WriteLine("tuesday");

            }

            else if (day == 3 || day == 10 || day == 17 || day == 24 || day == 31)
            {
                Console.WriteLine("wednesday");
            }

            else if (day == 4 || day == 11 || day == 19 || day == 27)
            {
                Console.WriteLine("thursday");

            }
            else if (day == 5 || day == 12 || day == 20 || day == 28)
            {
                Console.WriteLine("friday");

            }

            else if (day == 6 || day == 13 || day == 21 || day == 29)
            {
                Console.WriteLine("saturday");

            }

            else if (day == 7 || day == 14 || day == 21 || day == 28)
            {
                Console.WriteLine("sunday");

            }
        }

    }
}
