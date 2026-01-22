using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Print all numbers divisible by 3 and 5 up to N
    internal class Q8
    {
        public static void Execute()
        {
            int n = 30;
            int start = 1;
            while (start <= n)
            {
                if(start % 3 == 0 && start % 5 == 0)
                {
                    Console.WriteLine(start + " ");
                }
                start++;
            }
        }
    }
}
