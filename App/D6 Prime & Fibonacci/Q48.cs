using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D6_Prime___Fibonacci
{
    // Find the Nth Fibonacci Number
    internal class Q48
    {
        public static void Execute()
        {
            int n = 8;
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
    }
}
