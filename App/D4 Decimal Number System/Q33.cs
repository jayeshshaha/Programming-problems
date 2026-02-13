

namespace App.D4_Decimal_Number_System
{
    // Check if a Number is an Armstrong Number (also called a Narcissistic Number)
    internal class Q33
    {
        public static int CalculatePower(int n, int count)
        {
            int pow  = 1;   
            for (int i = 1; i <= count; i++)
            {
                pow = pow * n;
            }
            return pow; 
        }

        public static void Execute()
        {
            int originalNum = 153;
            int temp1 = originalNum;
            int count = 0;

            while (temp1 != 0)
            {
                count++;
                temp1 = temp1 / 10;
            }

            int sum = 0;
            int temp2 = originalNum;
            
            while (temp2 != 0)
            { 
                int num = temp2 % 10; 
                //double n1 = Math.Pow(num, count);
                //sum = sum + (int)n1;
                int num2 = CalculatePower(num, count);
                sum = sum + num2;
                temp2 = temp2 / 10;
  
            }
            if(sum == originalNum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong number");
            }
        

        }
    }
}
