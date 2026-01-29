namespace App.D2_Conditions___Logic
{
    // Check Triangle Type Using Sides and Angles
    internal class Q18
    {
        public static void CheckTriangleType(int a, int b, int c)
        {
           a *= a;
           b *= b;
           c *= c;
           if((a + b) == c){
            Console.WriteLine("Right-angled");
           }
           else if( a == b && a == c && b == a && b == c && c == a && c == b){
             Console.WriteLine("Equilateral");
           }
           else if((a == b || a == c ) || (b == a || b == c) || (c == a || c == b)){
             Console.WriteLine("Isosceles");
           } else {
            Console.WriteLine("Scalene");
           }
        }
        public static void Execute()
        {
            CheckTriangleType(3,9,5);
        }
    }
}
