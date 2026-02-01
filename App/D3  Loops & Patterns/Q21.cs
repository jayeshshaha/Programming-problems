using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D3__Loops___Patterns
{
    // Print Inverted Right-Angled Triangle
    internal class Q21
    {
        public static void Execute()
        {
            int row = 5;
            for (int i = row; i >= 1; i--)
            {
                for (int col = 1; col <= i; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
