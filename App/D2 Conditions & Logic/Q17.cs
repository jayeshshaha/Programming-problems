namespace App.D2_Conditions___Logic
{
    // Check if a Character is Uppercase, Lowercase, Digit, or Special Character
    internal class Q17
    {
        public static void Check(char chr)
        {
            if(chr >= 'a' && chr <= 'z')
            {
                Console.WriteLine("Lowercase");
            }
            else if(chr >= 'A' && chr <= 'Z')
            {
                Console.WriteLine("Uppercase");
            }
            else if (chr >= '0' && chr <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
        public static void Execute()
        {
            Check('a');
        }
    }
}
