using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D3__Loops___Patterns
{
    // Print Right-Angled Star Triangle
    public class Q20
    {
        public static void Execute()
        {
            int row = 5;
            for (int i = 1; i <= row; i++)
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
