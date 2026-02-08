using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_A___Understanding_Decimal_Number_System
{
    // Split Number into Digits

    internal class Q27
    {
        public static void Execute()
        {
            int n = 12345;
            List<int> list = new List<int>();   
            while (n != 0)
            {
               int num = n % 10;
               list.Add(num);
               n = n / 10;

            }
            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
