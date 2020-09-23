using System;

namespace TypeCasting
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Type Casting!");
         int myInt = 9;
         double myDouble = myInt;

         Console.WriteLine(myInt);
         Console.WriteLine(myDouble);

         double myDouble2 = 9.78;
         int myInt2 = (int) myDouble;
         
         Console.WriteLine(myDouble2);
         Console.WriteLine(myInt);

         int myInt3 = 10;
         double myDouble3 = 5.25;
         bool myBool = true;

         Console.WriteLine(Convert.ToString(myInt3));
         Console.WriteLine(Convert.ToDouble(myInt3));
         Console.WriteLine(Convert.ToInt32(myDouble));
         Console.WriteLine(Convert.ToString(myBool));
      }
   }
}
