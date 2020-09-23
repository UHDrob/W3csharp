using System;

namespace Variables
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello Variables!");

         string name = "John";
         Console.WriteLine("Hello " + name);

         int myNum = 15;
         Console.WriteLine(myNum);

         myNum = 20;  // myNum is now 20
         Console.WriteLine(myNum);

         const int QUINCE = 15;
         Console.WriteLine(QUINCE);

         string firstName = "John";
         string lastName = "Doe";
         string fullName = firstName + lastName;
         Console.WriteLine(fullName);

         int x = 5;
         int y = 6;
         Console.WriteLine(x + y);

         int a = 5, b = 6, c = 50;
         Console.WriteLine( a+ b + c);

         // Good
         int minutesPerHour = 60;
         Console.WriteLine(minutesPerHour);

      }
   }
}
