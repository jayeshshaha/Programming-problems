namespace App.D2_Conditions___Logic
{
    // Calculate Income Tax Based on Slabs
    public class Q19
    {
        public static void CheckIncomeTax(int income)
        {
            double tax;
            if(income <= 250000)
            {
                // 0%
                tax = 0;

            }
            else if (income <= 500000)
            {
                // 5%
                tax = (income - 250000) * 0.05;
            }
            else if (income <= 1000000)
            {
                // 20%
                tax = (250000 * 0.05)  + (income - 500000) * 0.2;
            }
            else
            {
                // 30%
                tax = (250000 * 0.05) + (500000 * 0.2) + ((income - 1000000) * 0.3);
            }
            Console.WriteLine(tax);
        }
        public static void Execute()
        {
            int income = 750000;
            CheckIncomeTax(income);
        }
    }
}
