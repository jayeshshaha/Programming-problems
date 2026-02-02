using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D3__Loops___Patterns
{
    // Print Pyramid Pattern
    internal class Q22
    {
        public static void Execute()
        {
            int rows = 3; 
            for (int i = 1; i <= rows; i++) 
            {
                for (int j = 1; j <= rows - i; j++) 
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

 