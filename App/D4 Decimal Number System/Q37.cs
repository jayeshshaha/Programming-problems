using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Check if a Number is a Strong Number
    internal class Q37
    {
        public static void Execute()
        {
            int originalNum = 145;
            int n = originalNum;
            int sum = 0;
            while (n != 0)
            {
                int num = n % 10;
                int factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }
                sum = sum + factorial;
                n = n / 10;
            }

            if(sum == originalNum)
            {
                Console.WriteLine("Strong Number " + sum);
            }
            else
            {
                Console.WriteLine("Not a Strong Number " + sum);
            }
           
        }
    }
}
