using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter letter");
            string letter = Console.ReadLine();

            switch(letter)

            {
                case "a" : Console.WriteLine("it is a vowel");
                    break;

                 case "e" : Console.WriteLine("it is a vowel");
                    break;

                 case "i" : Console.WriteLine("it is a vowel");
                    break;

                 case "o"  : Console.WriteLine("it is a vowel");
                    break;

                     case "u" : Console.WriteLine("it is a vowel");
                    break;

                default : Console.WriteLine("it's not a vowel");
                    break;

        }
    }
    }

}