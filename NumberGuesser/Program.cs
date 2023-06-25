using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
	class Program
	{
		static void Main(string[] args)
		{

			appInfo();
			greetUser();
			while (true)
			{

				Random random = new Random();
				int correctNumber = random.Next(1, 10);

				//Init guess var

				int guess = 0;

				Console.WriteLine("Guess a number between 1 and 10");

				//while guess is not correct
				while (guess != correctNumber)
				{
					string input = Console.ReadLine();

					//Make sure its a number

					if (!int.TryParse(input, out guess))
					{

						PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
						continue;
					}
					//Cast to input

					guess = Int32.Parse(input);

					// Match guess to correct number
					if (guess != correctNumber)
					{

						PrintColorMessage(ConsoleColor.Red, "wrong number, please try again");

					}
				}
				PrintColorMessage(ConsoleColor.Yellow, "You are correct");
		
				//Ask to play again
				Console.WriteLine("Play Again? [Y or N]");
				string answer = Console.ReadLine().ToUpper();
				if (answer == "Y")
				{
					continue;
				}
				else if (answer == "N")
				{
					return;
				}
				else
				{
					return;
				}






			}

			//Init correct number

			//int correctNumber = 7;

			//Create a Random object

		}
		static void appInfo()
		{
			string appName = "Number Guesser";
			string appVersion = "1.0.0";
			string authorName = "Varun";

			//Change text color
			Console.ForegroundColor = ConsoleColor.Green;

			//Write out app info

			Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, authorName);
			Console.ResetColor();
		}

		static void greetUser() {
			//Ask users name
			Console.WriteLine("What is your name?");

			//Get input name
			string inputName = Console.ReadLine();

			Console.WriteLine("Hello {0}, lets play a game ", inputName);
		}

		static void PrintColorMessage(ConsoleColor color, string message)
		{
			Console.ForegroundColor = color;

			Console.WriteLine(message);

			Console.ResetColor();
		}


	}
}
