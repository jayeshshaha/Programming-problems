namespace App.D2_Conditions___Logic
{
    // Check Triangle Type Using Sides and Angles
    internal class Q18
    {
        public static void CheckTriangleType(int a, int b, int c)
        {
          if(a == b && b == c){
             Console.WriteLine("Equilateral");
           }
           else if(a == b || b == c || a == c){
             Console.WriteLine("Isosceles");
           } else {
               if(((a * a)+ (b * b)) == (c * c)){
                   Console.WriteLine("Right-angled");
               } else{
               Console.WriteLine("Scalene");
               }
           }
        }
        
        public static void Execute()
        {
            CheckTriangleType(3,9,5);
        }
    }
}
