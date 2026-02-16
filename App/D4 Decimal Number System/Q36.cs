using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    internal class Q36
    {
        // Find the Largest and Smallest Digit in a Number
        public static void Execute()
        {
            int n = 9483;
            int largestNumber = n % 10;
            int smallestNumber = n % 10;
            while (n != 0)
            {
                int num = n % 10;
                if(num > largestNumber)
                {
                    largestNumber = num;
                }

                if (num < smallestNumber)
                {
                    smallestNumber = num;
                }
              
                n = n / 10; 
            }
            Console.WriteLine(largestNumber);
            Console.WriteLine(smallestNumber);
        }
    }
}
