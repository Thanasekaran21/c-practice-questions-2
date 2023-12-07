using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter c ");
            int c = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) > Math.Abs(b - c))
            {
                Console.WriteLine("a and b are farther");
            }


            else if (Math.Abs(b - c) < Math.Abs(a - b))
            {
                Console.WriteLine("b and a are farther");

            }
            else if (Math.Abs(a - b) < Math.Abs(b - c))
            {
                Console.WriteLine("a and c are farther");

            }

            else if (Math.Abs(b - c) > Math.Abs(a - b))
            {
                Console.WriteLine("b and c are farther");

            }

            else if (Math.Abs(c - a) < Math.Abs(c - b))
            {
                Console.WriteLine("c and a are further");

            }

            else if (Math.Abs(c - a) > Math.Abs(c - b))
            {
                Console.WriteLine("c and b are further");

}

            }
    }
}


