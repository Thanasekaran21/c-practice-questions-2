using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter calculation name");
            string calculationname = Console.ReadLine();

            switch (calculationname)
            {
                case "add": Console.WriteLine(a + b);
                    break;
                case "subtract": Console.WriteLine(a - b);
                    break;
                case "multiplication": Console.WriteLine(a * b);
                    break;
                case "division": Console.WriteLine(a / b);
                    break;
                case "modulo division": Console.WriteLine(a % b);
                    break;
                default: Console.WriteLine("error invalid output");
                    break;
            }


        }
    }
}
