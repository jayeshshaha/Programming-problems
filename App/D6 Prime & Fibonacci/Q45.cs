using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D6_Prime___Fibonacci
{
    // Check if a Number is Prime
    internal class Q45
    {
        public static void Execute()
        {
            int n = 7;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("Prime number");
            } else
            {
                Console.WriteLine("Not a Prime number");
            }
        }
    }
}
