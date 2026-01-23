using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D2_Conditions___Logic
{
    // Find the Maximum of Three Numbers
    internal class Q12
    {
        public static void Execute()
        {
            int a = 10;
            int b = 20;
            int c = 5;
            int largetNumber = 0;

            if(a > b && a > c){
                largetNumber = a;
            }
            else if(b > a && b > c){
                largetNumber = b;
            }
            else {
                largetNumber = c;
            }
            Console.WriteLine(largetNumber);

        }
    }
}
