using System;

namespace IfElse
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("If Else!");

         if (20>18)
         {
            Console.WriteLine("20 is greater than 18");
         }

         int x = 20;
         int y = 18;
         if (x > y)
         {
            Console.WriteLine("x is greater than y");

         }

         int time = 20;
         if (time < 10)
         {
            Console.WriteLine("Good Morning.");
         }
         else if ( time< 20)
         {
            Console.WriteLine("Good day");
         }
         else
         {
            Console.WriteLine("Good evening");
         }

         // Outputs "Good Evening"

         int time2 = 20;
         string result = (time < 18) ? "Good day" : "Good evening";
         Console.WriteLine(result);
      }
   }
}
