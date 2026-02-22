using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D5_Factors___Multiples
{
    // Print All Factors of a Number
    internal class Q41
    {
        public static void Execute()
        {
            int n = 24;
            List<int> list = new List<int>();   
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    list.Add(i);
                }
            }
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }
    }
}
