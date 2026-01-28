
/*
 Logic:
-------------------------------------------------
Divisble by 4 and not 100  -> Leap year
But if its divisble by 4 and 100 (for eg 1900) then it maynot be a leap year. Then we need to again check if its divisble by 400 (for eg 2000) then its Leap year.

 */

namespace App.D2_Conditions___Logic
{
    // Check if a Year is a Leap Year

    internal class Q16
    {
        public static bool CheckLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 != 0)
                {
                   return true;
                } 
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }
                }
     
            }
            return false;
        }
        public static void Execute()
        {
            int year = 2024;
            if (CheckLeapYear(year)) {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }

        }
    }
}
