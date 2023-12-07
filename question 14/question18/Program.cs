using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter month name");
            string month = Console.ReadLine();

            switch(month)

            {
                case "january": Console.WriteLine("it has 31 days");
                    break;
                case "february": Console.WriteLine("it has 28 days");
                    break;
                case "march": Console.WriteLine("it has 31 days");
                    break;
                case "may": Console.WriteLine("it has 31 days");
                    break;
                case "july": Console.WriteLine("it has 31 days");
                    break;
                case "august": Console.WriteLine("it has 31 days");
                    break;
                case "october": Console.WriteLine("it has 31 days");
                    break;
                case "december": Console.WriteLine("it has 31 days");
                    break;
                case "april": Console.WriteLine("it has 30 days");
                    break;
                case "june": Console.WriteLine("it has 30 days");
                    break;
                case "september": Console.WriteLine("it has 30 days");
                    break;
                case "november": Console.WriteLine("it has 30 days");
                    break;
            }
        }
    }
}
