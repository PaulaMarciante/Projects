using System;

namespace Fundamentals
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int myAge = 22;
			int yourAge = 35;

			const int retirement = 65;

			myAge = 50;
			//retirement = 72;

			string message = "Will we be able to retire soon?";

			int yearsToRetirementForYou = retirement - yourAge;
			int yearsToRetirementForMe = retirement - myAge;

			Console.WriteLine (message);

			Console.WriteLine ("Years to retirement for you: " + yearsToRetirementForYou);
			Console.WriteLine ("Years to retirement for me: {0}", yearsToRetirementForMe);
		}
	}
}
