using System;

namespace FirstApp4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int Age = 25; 
			string Name = "Judy";

			Console.WriteLine ("My name is " + Name + " and I am " + Age + " years old.");
			Console.WriteLine ("My name is {0} and I am {1} years old.",Name, Age );
		}
	}
}
