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
            Console.WriteLine("enter your option");
            string user = Console.ReadLine();
            Random computer = new Random();
            string[] cpoptions = { "rock", "paper", "scissors" };
            int index = computer.Next(cpoptions.Length);
            Console.WriteLine(cpoptions[index]);

            if (user == "rock" && cpoptions[index] == "paper")
            {

                Console.WriteLine("paper wraps rock winner : computer");

            }
            

        }

    }
}
