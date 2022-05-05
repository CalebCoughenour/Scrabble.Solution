using System;
using Scrabble;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Scrabble Word point checker!");
    Console.WriteLine("Please enter your word");
    string userInput = Console.ReadLine();
    Player inputWord = new Player(userInput);
    Console.WriteLine("Your Score " + inputWord.ScoreCalc());
  }
}