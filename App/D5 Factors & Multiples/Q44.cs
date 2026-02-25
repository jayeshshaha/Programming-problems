using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D5_Factors___Multiples
{
    // Find the LCM (Least Common Multiple) of Two Numbers
    internal class Q44
    {
        public static void Execute()
        {
            int num1 = 12; 
            int num2 = 18; 

      
            List<int> list = new List<int>();
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    list.Add(i);
                }
            }

            int hcf = 1;
            foreach (var item in list)
            {
                if (num2 % item == 0)
                {
                    hcf = item;

                }
            }

            int lcm = (num1 * num2) / hcf;
            Console.WriteLine(lcm);
        }
    }
}
