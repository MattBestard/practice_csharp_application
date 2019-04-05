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

            string sampString2 = "More random words";

            Console.WriteLine("Strings Equal " + sampString.Equals(sampString2));

            Console.WriteLine("Starts with \"A bunch\" " + sampString.StartsWith("A bunch"));

            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));
        }
    }
}
