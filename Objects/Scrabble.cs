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
			int count = 0;
			if(this.UserWord == "a" || this.UserWord =="e" ||this.UserWord == "i" || this.UserWord =="o" || this.UserWord =="u" || this.UserWord =="l" || this.UserWord =="n" || this.UserWord =="r" || this.UserWord =="s" || this.UserWord =="t")
			{
				count ++;
				return count;
			}else if (this.UserWord == "d"|| this.UserWord =="g")
			{
				count = count + 2;
				return count;
			}else if (this.UserWord =="b"|| this.UserWord =="c" || this.UserWord =="m" || this.UserWord =="p")
			{
				count = count + 3;
				return count;
			}else if(this.UserWord =="f" || this.UserWord =="h" || this.UserWord =="v" || this.UserWord == "w" || this.UserWord == "y")
			{
				count = count + 4;
				return count;
			}else if (this.UserWord =="k")
			{
				count+=5;
				return count;
			}else if (this.UserWord =="j" || this.UserWord =="x")
			{
				count+=8;
				return count;
			}else if (this.UserWord =="q" || this.UserWord =="z")
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
