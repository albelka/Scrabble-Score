using System.Collections.Generic;
using System;

namespace ScrabbleScore.Objects
{
	public class Scrabble
	{
		public string UserWord {get; set;}

		public Scrabble(string userWord)
		{
			this.UserWord = userWord;
		}

		public int ScoreIs()
		{
			string cleanWord = this.UserWord.ToLower();
			int count = 0;
			char[] wordArray = cleanWord.ToCharArray();
			Console.WriteLine(wordArray.Length);
			for(int i = 0; i< wordArray.Length; i++)
			{
				if(wordArray[i] == 'a' || wordArray[i]== 'e' || wordArray[i] == 'i' || wordArray[i] == 'o' || wordArray[i] == 'u' || wordArray[i] == 'l' || wordArray[i] == 'n' || wordArray[i] == 'r' || wordArray[i] == 's' || wordArray[i] == 't')
				{
					count ++;
				}
				else if (wordArray[i] == 'd'|| wordArray[i] == 'g')
				{
					count += 2;
				}
				else if (wordArray[i]== 'b'|| wordArray[i]== 'c' || wordArray[i]== 'm' || wordArray[i]== 'p')
				{
					count+= 3;
				}
				else if(wordArray[i] =='f' || wordArray[i] =='h' || wordArray[i] =='v' || wordArray[i] == 'w' || wordArray[i] == 'y')
				{
					count += 4;
				}
				else if (wordArray[i] =='k')
				{
					count += 5;
				}
				else if (wordArray[i] =='j' || wordArray[i] =='x')
				{
					count += 8;
				}
				else if (wordArray[i] =='q' || wordArray[i] =='z')
				{
					count += 10;
				}
				else
				{
					return count;
				}
			}
			return count;
		}
	}
}
