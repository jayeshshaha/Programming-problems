using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Remove the Decimal Point Mathematically
    internal class Q29
    {
        public static void Execute()
        {
            double n = 12.32;
            while (n != Math.Floor(n))
            {
                n = n * 10;
            }
            Console.WriteLine(n);

        }
    }
}
