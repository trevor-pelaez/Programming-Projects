using System;
using static System.Console;
class SubscriptExceptionTest
{
   static void Main()
   {
       double[] array = {20.3, 44.6, 32.5, 46.7, 89.6,
                        67.5, 12.3, 14.6, 22.1, 13.6};
      
      try
      {
        int x = 0;
        int max = 99;
        WriteLine("Enter subscript value or 99 to exit: ");
        x = Convert.ToInt32(ReadLine());
        do
        {
          Write("{0}", array[x]);
          Write("Enter subscript value or 99 to exit: ");
          x = Convert.ToInt32(ReadLine());
        }while (x < max);

      }
      catch (IndexOutOfRangeException e)
      {
        Write("Index was outside the bounds of the array.");
      }
       // Your code here
   }
}
