using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sides");
            int sides = int.Parse(Console.ReadLine());

            switch (sides)
            {
                case 1: Console.WriteLine("circle");
                    break;
                case 2: Console.WriteLine("digon");
                    break;
                case 3: Console.WriteLine("triangle");
                    break;
                case 4: Console.WriteLine("square");
                    break;
                case 5: Console.WriteLine("pentagon");
                    break;
                case 6: Console.WriteLine("hexagon");
                    break;
                case 7: Console.WriteLine("heptagon");
                    break;
                case 8: Console.WriteLine("octagon");
                    break;
                case 9: Console.WriteLine("nonagon");
                    break;
                case 10: Console.WriteLine("decagon");
                    break;
                default: Console.WriteLine("error");
                    break;



            }
        }
    }
}
