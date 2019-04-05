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
            string sampString = "A bunch of random words";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));

            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String length " + sampString.Length);
        }
    }
}
