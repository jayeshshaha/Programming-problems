using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D3__Loops___Patterns
{
    // Print Hollow Square Pattern
    internal class Q24
    {
        public static void Execute()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == rows)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");     
                    }
                   
                }
                Console.WriteLine();
            }

        }
    }
}
