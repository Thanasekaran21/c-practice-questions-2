using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter height of person 1 : ");
            int person1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter height of person 2 : ");
            int person2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter height of person 3 : ");
            int person3 = int.Parse(Console.ReadLine());

            if (person1 > person2 && person2 > person3 && person3 < person1)
            {
                Console.WriteLine("person3 is the tallest");

            }

            else if (person1 > person2 && person2 < person3 && person3 < person1)
            {
                Console.WriteLine("person3 is medium");
            }

            else if (person1 < person2 && person2 > person3 && person3 > person1)
            {
                Console.WriteLine("person3 is small");

            }

            //else if (person1 > person2 && person2 < person3 && person3 < person1)
            //{
            //    Console.WriteLine("person2 is tall");

            //}
            //else if (person1 > person2 && person2 > person3 && person3 < person1)
            //{
            //    Console.WriteLine("person2 is medium");
            //}

            //else if (person1 < person2 && person2 > person3 && person3 > person1)
            //{
            //    Console.WriteLine("person2 is small");
            //}

            //else if (person1 < person2 && person2 > person3 && person3 > person1)
            //{
            //    Console.WriteLine("person1 is tall");

            //}
            //else if (person1 < person2 && person2 < person3 && person3 > person1)
            //{
            //    Console.WriteLine("person1 is medium");
            //}

            //else if (person1 < person2 && person2 > person3 && person3 < person1)
            //{
            //    Console.WriteLine("person1 is small");
            //}

            else
            {
                Console.WriteLine("error");

            }
        }
    }
}
    

