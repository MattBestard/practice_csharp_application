using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp_application
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;

            do
            {
                Console.WriteLine("Guess a Number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));
        }
    }
}
