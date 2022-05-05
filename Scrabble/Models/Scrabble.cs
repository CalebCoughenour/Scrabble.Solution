using System;
using System.Linq;

namespace Scrabble
{
  public class WordScore
  {
   public char[] PointsOneArray {get; set;}
   public char[] PointsTwoArray {get; set;}
   public char[] PointsThreeArray {get; set;}
   public char[] PointsFourArray {get; set;}
   public char[] PointsFiveArray {get; set;}
   public char[] PointsEightArray {get; set;}
   public char[] PointsTenArray {get; set;}

   public WordScore(char[] pointsOne, char [] pointsTwo, char [] pointsThree, char [] pointsFour, char [] pointsFive, char [] pointsEight, char [] pointsTen)
    {
    PointsOneArray = pointsOne;
    PointsTwoArray = pointsTwo;
    PointsThreeArray = pointsThree;
    PointsFourArray = pointsFour;
    PointsFiveArray = pointsFive;
    PointsEightArray = pointsEight;
    PointsTenArray = pointsTen;
    }
  } 
    
  public class Player
  {
    public string UserWord {get; set;}
    public char[] UserWordArray {get; set;}
    public Player(string word)
    {
      UserWord = word;
      UserWordArray = word.ToCharArray();
    }
  }
}