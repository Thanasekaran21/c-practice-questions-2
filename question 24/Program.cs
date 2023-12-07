using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter invested amount");
            int investment = int.Parse(Console.ReadLine());
            Console.WriteLine("enter solded amount");
            int sold = int.Parse(Console.ReadLine());

            if (investment<sold)

            {
                Console.WriteLine("profit");

            }

            else if (investment>sold)

            {
                Console.WriteLine("loss");

            }

            else 
            {
                Console.WriteLine("error");

            }


        }
    }
}
