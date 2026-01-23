using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Print only the numbers that are both even and perfect squares
    internal class Q11
    {
        public static void Execute()
        {
            int l = 1;
            int r = 20;

            while (l <= r) 
            {
                if(l % 2 == 0)
                {
                    int square = l * l;
                    if(square % 2 == 0 && square <= r)
                    {
                        Console.WriteLine(square + " ");
                    }               
                }
                l++;
            }
        }
    }
}
