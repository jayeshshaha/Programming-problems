using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Find the Sum of Digits
    internal class Q34
    {
     
        public static void Execute()
        {
            int n = 987;
            int sum = 0;    
            while (n != 0)
            {
                int num = n % 10;
                sum += num;
                n = n / 10; 

            }
            Console.WriteLine(sum);
        }
    }
}
