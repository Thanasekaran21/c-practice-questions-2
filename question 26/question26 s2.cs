using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter any one of the following Rock,Paper,Scissors"); 
            Console.WriteLine("enter your option");
            string user = Console.ReadLine();
            Random computer = new Random();
            int cpoptions = computer.Next(1, 4);

            if (cpoptions==1)

            {
                Console.WriteLine("Rock");

            }

            else if (cpoptions==2)
            {
                Console.WriteLine("Paper");
            }

             else if (cpoptions==3)
            {
                Console.WriteLine("Scissors");
            }




            if (user == "rock" && cpoptions == 2)
            {

                Console.WriteLine("paper wraps rock winner : computer");

            }
            

        }

    }
}
