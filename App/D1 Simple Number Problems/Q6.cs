using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Sum of All Even Numbers up to N
    internal class Q6
    {
        public static void Execute()
        {
            int n = 10;
            int sum = 0;
            while (n != 0)
            {
                if(n % 2 == 0)
                {
                    sum += n;                  
                }
                n--;
            }
            Console.WriteLine(sum);


        }
    }
}
