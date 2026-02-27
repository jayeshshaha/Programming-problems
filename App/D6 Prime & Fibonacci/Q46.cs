using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.D6_Prime___Fibonacci
{
    // Check if two Numbers are Co-Prime
    internal class Q46
    {
        public static void Execute()
        {
            int num1 = 7; // 1 7
            int num2 = 8; //  1 2 4 8
            
            List<int> list = new List<int>();
            for (int i = 1; i <= num1; i++)
            {
                if(num1 % i == 0)
                {
                    list.Add(i);
                }
            }

            int hcf = 0;
            foreach (int i in list)
            {
                if(8 % i  == 0)
                {
                    hcf = i;
                }
            }
            if(hcf == 1)
            {
                Console.WriteLine("Co-Prime");
            }
            else
            {
                Console.WriteLine("Not a Co-Prime");
            }
            Console.WriteLine(hcf);

        }
    }
}
