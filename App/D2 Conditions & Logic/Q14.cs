using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace App.D2_Conditions___Logic
{
    internal class Q14
    {
        public static void Execute()
        {
            int units = 230;

            int totalCost = 0;
            if(units <= 100)
            {
                totalCost = 100 * 5;
            } 
            else if(units > 100 && units <= 200)
            {
                totalCost = (100 * 5) + (units - 100) * 7; 
               
            }
            else if (units > 200 && units <= 300)
            {
                totalCost = (100 * 5) + (100 * 7)  + (units - 200) * 10;
            }
            else
            {
                totalCost = (100 * 5) + (100 * 7) + (100 * 10) + (units - 300) * 12 ;
            }

            Console.WriteLine(totalCost);

        }
    }
}
