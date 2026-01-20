using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Print All Even Numbers from 1 to N
    internal class Q3
    {
        public static void Execute()
        {
            int start = 1;
            int n = 5;
            while (start <= n)
            {
                if (start % 2 == 0)
                {
                    Console.Write(start + " ");
                }
                start++;
            }

        }
    }
}
