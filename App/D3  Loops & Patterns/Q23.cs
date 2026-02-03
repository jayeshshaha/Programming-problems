using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D3__Loops___Patterns
{
    // Print Inverted Pyramid Pattern
    public class Q23
    {
        public static void Execute()
        {
            int rows = 3;
            for (int i = rows; i >= 1; i--)
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
