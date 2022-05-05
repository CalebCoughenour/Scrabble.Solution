using System;
using System.Linq;

namespace Scrabble
{
  public class Player
  {
    public string UserWord {get; set;}
    public char[] UserWordArray {get; set;}
    public int UserPoints {get; set;}
    public Player(string word)
    {
      UserWord = word;
      UserWordArray = word.ToLower().ToCharArray();
      UserPoints = 0;
    }

    public int ScoreCalc()
    {
      foreach(char Character in UserWordArray)
      {                 
        if ((Character.Equals('d')) || (Character.Equals('g')))
        {
          UserPoints += 2;
        }
        else if ((Character.Equals('b')) || (Character.Equals('c')) || (Character.Equals('m')) || (Character.Equals('p'))) 
        {
          UserPoints += 3;
        }
        else if ((Character.Equals('f')) || (Character.Equals('h')) || (Character.Equals('v')) || (Character.Equals('w')) || (Character.Equals('y')))
        {
          UserPoints += 4;
        }
        else if ((Character.Equals('k')))
        {
          UserPoints += 5;
        }
        else if ((Character.Equals('j')) || (Character.Equals('x')))
        {
          UserPoints += 8;
        }
        else if ((Character.Equals('q')) || (Character.Equals('z')))
        {
          UserPoints += 10;
        }
        else
        {
          UserPoints += 1;
        }
      }
      return UserPoints;
    }
  }
}