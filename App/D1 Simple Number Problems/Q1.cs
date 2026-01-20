using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Print Numbers from 1 to N
    public static class Q1
    {
        public static void Execute()
        {
            int n = 5;
            int start = 1;
            while (start <= n)
            {
                Console.WriteLine(start);
                start++;              
            }
        }

    }
}
