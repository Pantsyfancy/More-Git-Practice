using System;

namespace More_Git_Practice
{
	class Program
	{
		const string fightCommand = "fight";
		const string fleeCommand = "flee";

		static void Main(string[] args)
		{
			RunChoice();
		}

		static void RunChoice()
		{
			Console.WriteLine("Pantsyfancy bites!");
			Console.WriteLine($"Will you {fightCommand.ToUpper()} or {fleeCommand.ToUpper()}?");
			string action = Console.ReadLine();

			RunFightOrFlight(action);
		}

		static void RunFightOrFlight(string action)
		{
			if (action.ToLower() == fightCommand)
			{
				Console.WriteLine("Pantsyfancy bites your head off.");
				Console.WriteLine("You have died.");
				RunFinal();
			}
			else if (action.ToLower() == fleeCommand)
			{
				Console.WriteLine("You flee and never look back.");
				RunFinal();
			}
			else
			{
				Console.WriteLine("You have only 2 options!");
				RunChoice();
			}
		}

		static void RunFinal()
		{
			Console.WriteLine("Any key to exit.");
			Console.ReadKey();
		}
	}
}
