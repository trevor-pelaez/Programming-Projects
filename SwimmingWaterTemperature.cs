using System;
using static System.Console;
class SwimmingWaterTemperature
{
   static void Main()
   {
       int max = 999; 
       int temp = 0;
       bool safe = false;
       WriteLine("Enter water temp or 999 to quit: ");
       temp = Convert.ToInt32(ReadLine());
       while (temp < max)
       {
         try
          {
            safe = CheckComfort(temp);
            if (safe == true)
              WriteLine("{0} degrees is comfortable for swimming.", temp);
            else
              WriteLine("{0} degrees is not comfortable for swimming.", temp);
          }
         catch(ArgumentException )
         {
           WriteLine("Value does not fall within the expected range.");
           WriteLine("Enter another temperature or 999 to quit");
         }
         WriteLine("Enter another temperature or 999 to quit");
         temp = Convert.ToInt32(ReadLine());
       }
       // Your code here
   }
    
    public static Boolean CheckComfort(int temp) 
    {
      Boolean safe = false;
      int boil = 212;
      int freeze = 32;
      int low = 70;
      int high = 85;
      if (temp > boil || temp < freeze)
        {
          throw(new ArgumentException());
        }
      if (temp > low && temp < high)
          safe = true;
       
      return safe;
      // your logic here   
    }
}
