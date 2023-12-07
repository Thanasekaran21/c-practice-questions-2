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

            Console.WriteLine("b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c ");
            int c = int.Parse(Console.ReadLine());

            if  (Math.Abs (a - b) > Math.Abs( b - c ) )
            {
                Console.WriteLine("a and b are farther");

            }
            else if (Math.Abs (a - b) <Math.Abs (b - c ))
            {
                Console.WriteLine("a and c are farther");

            }
            else if( Math.Abs (b - c) > Math.Abs (a - b) )
            {
                Console.WriteLine("b and c are farther");

            }



        }
    }
}
