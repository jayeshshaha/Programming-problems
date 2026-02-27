using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D6_Prime___Fibonacci
{
    //  Print Fibonacci Series up to N Terms
    internal class Q47
    {
        public static void Execute()
        {
            int n = 10; // 0 1 1 2 3 5 8 13
            int a = 0;   // 0 1
            int b = 1;  //  1 2
            int c = 0; //   1 2 3
            int count = 2;
            Console.Write(a + " " + b + " ");
            while(count < n)
            {
                c = a + b;   
                Console.Write(c + " ");
                a = b;
                b = c;
                count++;
            }


        }
    }
}
