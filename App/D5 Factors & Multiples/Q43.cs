using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D5_Factors___Multiples
{
    // Find the HCF (Highest Common Factor) or GCD of Two Numbers
    internal class Q43
    {
        public static void Execute()
        {
            int num1 = 12; // 1 2 3 4 6
            int num2 = 18; // 1 2 3 6 9

            // 2 | 6 9
            // 3 | 2 3
            //  2 * 3 = 6

            List<int> list = new List<int>();
            for (int i = 1; i <= num1; i++)
            {
               if(num1 % i == 0)
                {
                    list.Add(i);
                }   
            }

            int hcf = 1;
            foreach (var item in list)
            {
                if(num2 % item == 0)
                {
                    hcf = item;
                  
                }
            }




        }
    }
}
