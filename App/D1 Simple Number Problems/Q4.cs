using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D1_Simple_Number_Problems
{
    // Sum of First N Natural Numbers
    internal class Q4 
    {
        public static void Execute()
        {
            int n = 5;    
            int sum = 0;  
            while (n != 0) 
            {
                sum = sum + n;
                n--;

            }
            Console.WriteLine(sum);
        }
        
    }
}
