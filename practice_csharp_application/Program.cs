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

            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:00,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr);
        }
    }
}
