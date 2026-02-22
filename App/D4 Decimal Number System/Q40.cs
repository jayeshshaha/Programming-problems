using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.D4_Decimal_Number_System
{
    // Check if a Number is an Harshad Number 
    internal class Q40
    {
        public static void Execute(){
        int originalNum = 18;
          int n = originalNum;
          int sum = 0;
          while(n != 0){
              int num = n % 10;
              sum += num;
              n = n / 10;
          }
          
           Console.WriteLine(sum);
          bool check = originalNum % sum  == 0;
          if(check){
              Console.WriteLine("Harshad Number");
          } else {
              Console.WriteLine("Not Harshad Number");
          }
          
      }
       
    }
}
