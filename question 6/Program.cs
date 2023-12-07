using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <= 60) 

            {
                Console.WriteLine("your eligible to vote");

            }

            else if (age>0 && age<18)

            {
                Console.WriteLine("your not eligible");

            }
            else
            {
                Console.WriteLine("error");

        }
    }
    }
}
