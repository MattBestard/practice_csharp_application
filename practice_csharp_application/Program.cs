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
            int[] longArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            for (int i = 0; i < longArr.Length; i++)
            {
                Console.WriteLine(longArr[i]);
            }
        }
    }
}