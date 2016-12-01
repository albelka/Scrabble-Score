using Nancy;
using System.Collections.Generic;
using ScrabbleScore.Objects;
using System;

namespace ScrabbleScore
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				Dictionary<string, int> objects = new Dictionary<string, int>();
				objects["HasWord"] =0;
				Console.WriteLine(objects["HasWord"]);
				return View["index.cshtml", objects];
			};

			Post["index.cshtml"] = _ =>
			{
				Dictionary<string, int> objects = new Dictionary<string, int>();
				objects["HasWord"] =1;
				string userWord = Request.Form["word"];
				Console.WriteLine(userWord);
				Scrabble newScrabble = new Scrabble(userWord);
				objects["ScrabbleScore"] = newScrabble.ScoreIs();
				Console.WriteLine(objects["ScrabbleScore"]);
				return View["index.cshtml", objects];
			};
		}
	}
}
