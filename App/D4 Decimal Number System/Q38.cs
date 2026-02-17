using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Find the Frequency of Each Digit
    internal class Q38
    {
        public static void Execute()
        {
            int n = 888112233;
            int[] arr = new int[10];
            while (n != 0)
            {
                int num = n % 10;
                for (int i = 0; i < 9; i++)
                {
                    if(i == num)
                    {
                        arr[i]++;
                    }
                }
                n = n / 10; 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine($"Frequency of {i} is {arr[i]}");
                }
            }
        }
    }
}
