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
            string randStr = "Here are some random character";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }
        }
    }
}
