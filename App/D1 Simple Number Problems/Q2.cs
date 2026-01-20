using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Print Numbers from N to 1 without changing the loop condition of above question
    internal static class Q2
    {
        public static void Execute()
        {
            int n = 5;
            int start = 1;
            while (start <= n)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
