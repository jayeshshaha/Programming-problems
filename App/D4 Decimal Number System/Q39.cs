using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Check if a Number is an Automorphic Number
    internal class Q39
    {
        public static void Execute()
        {
            int originalNum = 25;
            int n = originalNum;
            int square = n * n; // 625

            int count = 0;
            while (n != 0)
            {
                int num = n % 10;
                count++;
                n = n / 10;
            }

            int factor = 1;
            for (int i = 0; i < count; i++)
            {
                factor = factor * 10;
            }

            if(square % factor == originalNum)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not a Automorphic Number"); 
            }
        }
    }
}
