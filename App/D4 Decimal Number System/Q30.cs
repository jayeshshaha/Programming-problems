using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Separate Whole and Fractional Parts of a Number
    internal class Q30
    {
        public static void Execute()
        {
            double n = 5.75;
           
            double fraction = n % 1;
            double whole = n - fraction;
            Console.WriteLine("Whole = " + whole);
            Console.WriteLine("Fraction = " + fraction);
        }
    }
}
