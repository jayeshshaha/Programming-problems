using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Check if a Number is a Palindrome
    internal class Q32
    {
        public static void Execute()
        {
            int originalNum = 121;
            int n = originalNum;
            int reversedNum = 0;
            while (n != 0)
            {
                int num = n % 10;
                reversedNum = (reversedNum * 10) + num;
                n = n / 10;
            }

            if (originalNum == reversedNum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }

        }
    }
}
