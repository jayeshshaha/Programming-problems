using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D5_Factors___Multiples
{
    // Print All Multiples of a Number up to N
    internal class Q42
    {
        public static void Execute()
        {
            int num = 4;
            int limit = 30;
            
            List<int> list = new List<int>(); 
            for (int i = 1; i <= limit; i++)
            {
                int multiple = num * i;
                if (multiple > limit)
                {
                    break;
                }
                list.Add(multiple);
                             
            }
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }
    }
}
