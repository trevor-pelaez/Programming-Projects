using System;
using static System.Console;
class ExceptionsOnPurpose3
{
	static void Main()
	{
		int answer = 0;
		int result;
		int zero = 0;
		try
		{
			Write("Enter an integer >> ");
			answer = Convert.ToInt32(ReadLine());
			result = answer / zero;
		}
		catch(FormatException e)
		{
			WriteLine("You did not enter an integer.");
		}
		catch(DivideByZeroException e)
		{
			WriteLine("This is not your fault.");
			WriteLine("You entered the integer correctly.");
			WriteLine("The program divides by zero.");
		}
		WriteLine("The answer is " + answer);
	}
}