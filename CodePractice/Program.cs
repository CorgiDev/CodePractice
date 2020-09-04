using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GFG
{
	static public void Main()
	{
		// Prompt: Given a string which may contains lowercase and uppercase chracters. 
		// The task is to remove all  duplicate characters from the string and print the resultant string.  
		// The order of remaining characters in the output should be same as in the original string.

		// Questions:
		// Do we need to remove spaces? No
		// Does capitalization impact if we count something as a duplicate? No

		// Phrase being given to method
		string originalPhrase = "HappyNewYear";
		string noDups = RemoveDeuplicates(originalPhrase);
		Console.WriteLine("Remove duplicate characters from single phrase:");
		Console.WriteLine(noDups);

		string[] wordList = new string[] { "HappyNewYear", "geeksforgeeks" };
		Console.WriteLine("Remove duplicate characters from all phrases in list:");
		RemoveDeuplicatesMultiple(wordList);
	}

	static string RemoveDeuplicates(string oldPhrase)
	{
		// Blank string for new phrase to go into.
		string newPhrase = "";

		// Loop through oldPhrase, and check if character in newPhrase
		for (int i = 0; i < oldPhrase.Length - 1; i++)
		{
			// If not, add it to the newPhrase
			if (!newPhrase.Contains(oldPhrase[i]))
			{
				newPhrase += oldPhrase[i];
			}
			// If it is, continue to next character in old phrase
			else if (newPhrase.Contains(oldPhrase[i]))
			{
				continue;
			}
		}
		return newPhrase;
	}

	static void RemoveDeuplicatesMultiple(string[] phraseList)
	{
		List<string> newList = new List<string>();

		foreach (string phrase in phraseList)
		{
			// Blank string for new phrase to go into.
			string newPhrase = "";

				// Loop through oldPhrase, and check if character in newPhrase
			for (int i = 0; i < phrase.Length - 1; i++)
			{
				// If not, add it to the newPhrase
				if (!newPhrase.Contains(phrase[i]))
				{
					newPhrase += phrase[i];
				}
				// If it is, continue to next character in old phrase
				else if (newPhrase.Contains(phrase[i]))
				{
					continue;
				}
			}
			newList.Add(newPhrase);
		}

		newList.ForEach(Console.WriteLine);
	}
}