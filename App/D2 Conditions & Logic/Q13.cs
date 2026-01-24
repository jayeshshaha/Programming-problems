using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D2_Conditions___Logic
{
    // Check if a Number is Positive, Negative, or Zero
    internal class Q13
    {
        public static void Execute()
        {
            int input = 5;
            if(input > 0)
            {
                Console.WriteLine("Positive");
            } else if (input < 0)
            {
                Console.WriteLine("Negative");
            } else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
