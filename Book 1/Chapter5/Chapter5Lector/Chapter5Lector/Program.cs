using System;
using System.Collections.Generic;


namespace Chapter5Lector
{
	class Program
	{
		public static void Main()
		{
			//Dictionary's are collections of a key/value pairs - just strongly typed. They can be of any type(int, string, bool, custom, etc).

			//////////////////////////////////////
			////How to make a dictionary in C#///
			////////////////////////////////////
			//makes a dictionary named 'toysSold' and adds key value pairs at the sane time, you can also make an empty dictionary and use nameOfDictionary.Add(Key, Value)
			Dictionary<string, int> toysSold = new Dictionary<string, int>() {
					{"Hot Wheels", 344},
					{"Legos", 763},
					{"Gaming Consoles", 551},
					{"Board Games", 298}
				};

			Dictionary<string, int> Test = new Dictionary<string, int>()
			{
				{"true", 345},
				{"false", 452},
				{"maybe", 853},
				{"sometimes", 124},
			};
			//////////////////////////////////////////////////////////////////////////////////////////
			////how to use .Add(Key, Value) to add KeyValuePairs to the dictionary named "toysSold"///
			//////////////////////////////////////////////////////////////////////////////////////////
			//  "GI Joe" = Key   and   430 = Value || together they make a KeyValuePair
			toysSold.Add("GI Joe", 430);
			Test.Add("eh", 921);
			//access and print this newly added Value(430) to the console by using the key of "GI Joe"
			Console.WriteLine(toysSold["GI Joe"]);


			////////////////////////////////////////////////////////////////////////
			////How to loop over the dictionary and print each toy & its price/////
			///////////////////////////////////////////////////////////////////////
			Console.WriteLine("****toysSold Dictionary****");//title of list you are about to print
			foreach (KeyValuePair<string, int> toys in toysSold)
			{
				Console.WriteLine($"{toys.Key} price ${toys.Value}");
			}

			foreach (KeyValuePair<string, int> tests in Test)
			{
				Console.WriteLine($"{tests.Value} is {tests.Key}!");
			}

			//now lets make anither Dictionary that contains your top 5 video games, rank 1-5 would be of type 'int', and the name of the game would be type 'string'		
			////////////////////////////////////////////
			////How to make an empty dictionary in C#///
			////////////////////////////////////////////
			Dictionary<int, string> top5VideoGames = new Dictionary<int, string>();

			//now we have an empty dictionary called 'top5VideoGames, lets add some games with .Add() instead of using {key, value} after creating te Dictionary like the first dictionary we created      
			top5VideoGames.Add(1, "HL2DM");
			top5VideoGames.Add(2, "Diablo 2");
			top5VideoGames.Add(3, "Halo 2");
			top5VideoGames.Add(4, "World of Warcraft, vanilla");
			top5VideoGames.Add(5, "Starcraft Broodwars");

			//Now lets loop over the dictionary and print each key value pair to the Console
			//First lets print a title to the console
			Console.WriteLine("****Top 5 Video Games of all Time****");
			//loop over Dictionary and print each one
			foreach (KeyValuePair<int, string> game in top5VideoGames)
			{
				Console.WriteLine(game.Key + " " + game.Value);
			}


			//how to check if an int(key) is in the dictionary -- here we check if the Dictionary has a key of 3
			Console.WriteLine("***How to check if a certain key exists in a dictionary with an if-else statement***");
			//create an empty variable
			string value;
			if (top5VideoGames.ContainsKey(3))
			{
				value = top5VideoGames[3];
				Console.WriteLine($"{value} exists in the dictionary");
			}
			else
			{
				Console.WriteLine("Key Not Present");
				return;
			}
		}
	}
}
