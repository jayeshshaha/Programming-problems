using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    internal class Q35
    {
        public static void Execute()
        {
            int n = 4567;
            double sum = 0;
            int count = 0;
            while (n != 0)
            {
                double num = n % 10;
                sum += num;
                n = n / 10;
                count ++;   
            }
            double avgNumber = sum / count;
            Console.WriteLine(avgNumber);
        }
    }
}
