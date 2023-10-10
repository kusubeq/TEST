using System;
using System.Threading;

public class Program
{
	public static void Main()
	{
		gameIntro();
	}

	public static void gameIntro()
	{
		Console.WriteLine("Hello and welcome to the City of Awesomeness text adventure. In this adventure you will choose a character and go on a mystical journey through feudal Japan(well Sekol’s Japan). Spelling is very important throughout the game, so please be observant of the commands. You never know when mistyping a word will offend a passing Ronin. Believe me, you don’t want to see what happens when you offend a samurai that has no master. Either way, welcome!  It’s very rare we see someone of your caliber, thank you for visiting. To enter the city, check-in with the gatekeeper. To begin, press enter to visit the gatekeeper.");
		Console.WriteLine("Press Enter to walk over to gatekeeper");
		Console.ReadLine();
		//Console.Clear(); // <-- Does like clearing the console. 
		first();
	}
	public static void first()
	{
		string characterName;
		string characterClass;

		Console.WriteLine("Why hello there! I am gatekeeper Kaizen. What is your name?");
		characterName = Console.ReadLine();
		//Doesn't like the $ to pass through variables. i.e. $"It is an honor to meet you {characterName}"
		Console.WriteLine("It is an honor to meet you " + characterName);

		Console.WriteLine(characterName + " thank you for visiting. To enter, may I have your warrior class?");
		Console.WriteLine("1. Ninja");
		Console.WriteLine("2. Mage");
		Console.WriteLine("3. Samurai");
		Console.WriteLine("4. Warlord");
		characterClass = Console.ReadLine().ToLower();

		switch (characterClass)
		{
			case "1":
			case "ninja":
				{
					Console.WriteLine("I did not want to assume, but I sensed great stillness within you.");
				}
				break;

			case "2":
			case "mage":
				{
					Console.WriteLine("Wow. Your greatness is recorded in the books of time.");
				}
				break;

			case "3":
			case "samurai":
				{
					Console.WriteLine("Ah noble warrior... it is an honor to meet you.");
				}
				break;

			case "4":
			case "warlord":
				{
					Console.WriteLine("I know of your violent history. The Ronin are watching you. Tread lightly sir.");
				}
				break;

			default:
				{
					Console.WriteLine("Hmmm... you did not speak very clearly, please begin again, but this time be more respectful. Once you enter the gates deadly Ronin are every where.");
					Thread.Sleep(2000);
					Console.WriteLine("...you did not speak very clearly, please begin again, but this time be more respectful. Once you enter the gates deadly Ronin are every where.");
					first();
				}
				break;



		}



	}

}