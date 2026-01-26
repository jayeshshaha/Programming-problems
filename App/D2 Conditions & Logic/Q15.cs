using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D2_Conditions___Logic
{
    // Check if a Character is a Vowel or Consonant
    internal class Q15
    {
        public static void Execute()
        {
            char chr = 'a';
            if(chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
