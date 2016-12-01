using System.Collections.Generic;

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
			if(cleanWord == "a" || cleanWord =="e" ||cleanWord == "i" || cleanWord =="o" || cleanWord =="u" || cleanWord =="l" || cleanWord =="n" || cleanWord =="r" || cleanWord =="s" || cleanWord =="t")
			{
				count ++;
				return count;
			}else if (cleanWord == "d"|| cleanWord =="g")
			{
				count = count + 2;
				return count;
			}else if (cleanWord =="b"|| cleanWord =="c" || cleanWord =="m" || cleanWord =="p")
			{
				count = count + 3;
				return count;
			}else if(cleanWord =="f" || cleanWord =="h" || cleanWord =="v" || cleanWord == "w" || cleanWord == "y")
			{
				count = count + 4;
				return count;
			}else if (cleanWord =="k")
			{
				count+=5;
				return count;
			}else if (cleanWord =="j" || cleanWord =="x")
			{
				count+=8;
				return count;
			}else if (cleanWord =="q" || cleanWord =="z")
			{
				count+=10;
				return count;
			}else
			{
				return 0;
			}
		}
	}
}
