using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c ");
            int c = int.Parse(Console.ReadLine());

            int smallest = c;


            if (a < smallest)
            {

                smallest = a;

            }
            if (b < smallest)
            {

                smallest = b;
            }

            Console.WriteLine(smallest);



        }
    }
}


       
    
