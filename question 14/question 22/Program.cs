using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            string character = Console.ReadLine();
            Console.WriteLine("enter row");
            int row = int.Parse(Console.ReadLine());

            if (character == "a"  && row % 2 == 0)

            {
                Console.WriteLine("white");

            }

            else if (character == "c" && row % 2 == 0)

            {
                 Console.WriteLine("white");

            }


            else if  (character == "e"  && row % 2 == 0)

            {
                 Console.WriteLine("white");
            }

            else if (character == "g" && row % 2 == 0 )
            {
                Console.WriteLine("white");
            }

            else if(character == "a"  && row % 2 != 0)

            {
                Console.WriteLine("black");

            }

            else if (character == "c" && row % 2 != 0)

            {
                 Console.WriteLine("black");

            }


            else if  (character == "e"  && row % 2 != 0)

            {
                 Console.WriteLine("black");
            }

            else if (character == "g" && row % 2 != 0 )
            {
                Console.WriteLine("black");
            }
           

            else if (character == "b" && row % 2 == 0)
            {
                Console.WriteLine("black");
            }

                else if (character == "d" && row % 2 == 0)
            {
                    Console.WriteLine("black");
                }
                
                else if ( character == "f" && row % 2 == 0)
            {
                    Console.WriteLine("black");
                }
                    else if (character == "h" && row % 2 == 0)
            {
                        Console.WriteLine("black");
                    }
          
            else if (character == "b" && row % 2 != 0)
            {
                Console.WriteLine("white");
            }

            else if (character == "d" && row % 2 != 0)
            {
                Console.WriteLine("white");
            }

            else if (character == "f" && row % 2 != 0)
            {
                Console.WriteLine("white");
            }
            else if (character == "h" && row % 2 != 0)
            {
                Console.WriteLine("white");
            }
            else
            {
                Console.WriteLine("invalid input");

            }
        }
    }
}