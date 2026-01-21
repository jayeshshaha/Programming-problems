using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Product (Factorial) of N
    internal class Q5
    {
        public static void Execute()
        {
            int n = 5; 
            int factorial = 1;
            while (n != 0)
            {
                factorial = factorial * n;
                n--;

            }
            Console.WriteLine(factorial);

        }
    }
}
