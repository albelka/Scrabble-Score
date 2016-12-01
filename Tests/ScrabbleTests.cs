using Xunit;

namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void ScoreIs_SingleLetterScore_score()
    {
      string userWord = "a";
      Scrabble newScrabble = new Scrabble(userWord);
      //UserInput newInput = new UserInput();
      Assert.Equal(10, newScrabble.ScoreIs());
    }
  }
}
