namespace App.D4_Decimal_Number_System
{
    // Revese a number
    internal class Q28
    {
        public static void Execute()
        {
            int n = 12345;
            int reverseNum = 0; 
            while(n != 0)
            {
                int num = n % 10;
                reverseNum = (reverseNum * 10) + num;
                n = n / 10; 

            }
            Console.WriteLine(reverseNum);
        }
    }
}
