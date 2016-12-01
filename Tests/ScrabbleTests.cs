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
      Assert.Equal(1, newScrabble.ScoreIs());
    }
    [Fact]
    public void ScoreIs_CaseSensitiveScore_score()
    {
      string userWord = "A";
      Scrabble newScrabble = new Scrabble(userWord);
      Assert.Equal(1, newScrabble.ScoreIs());
    }
    [Fact]
    public void ScoreIs_NotALetter_score()
    {
      string userWord = "?";
      Scrabble newScrabble = new Scrabble(userWord);
      Assert.Equal(0, newScrabble.ScoreIs());
    }
    [Fact]
    public void ScoreIs_WholeWord_score()
    {
      string userWord = "Zygote";
      Scrabble newScrabble = new Scrabble(userWord);
      Assert.Equal(19, newScrabble.ScoreIs());
    }
  }
}
