using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Print Squares of Numbers from 1 to N
    internal class Q7
    {
        public static void Execute()
        {
            int n = 5;
            int start = 1;
            while (start <= n)
            {
                int square = start * start;
                Console.Write(square + " ");
                start++;
            }
        }
    }
}
