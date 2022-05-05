using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Scrabble.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void StringToChar_ArrayOfCharacters_Char()
    {
    Player inputWord = new Player("Hello");
    char[] charArray = {'h', 'e', 'l', 'l', 'o'};
    Assert.AreEqual(true, charArray.SequenceEqual(inputWord.UserWordArray));
    }

    [TestMethod]
    public void ScoreCalc_AddOnePointCalc_Int()
    {
      Player inputWord = new Player("Hello");
      inputWord.ScoreCalc();
      Assert.AreEqual(8, inputWord.UserPoints);
    }
    [TestMethod]
    public void ScoreCalc_AddTwoPointCalc_Int()
    {
      Player inputWord = new Player("Good");
      inputWord.ScoreCalc();
      Assert.AreEqual(6, inputWord.UserPoints);
    }
    [TestMethod]
    public void ScoreCalc_AddThreePointCalc_Int()
    {
      Player inputWord = new Player("Morning");
      inputWord.ScoreCalc();
      Assert.AreEqual(10, inputWord.UserPoints);
    }
    [TestMethod]
    public void ScoreCalc_AddFourPointCalc_Int()
    {
      Player inputWord = new Player("adcy");
      inputWord.ScoreCalc();
      Assert.AreEqual(10, inputWord.UserPoints);
    }
    [TestMethod]
    public void ScoreCalc_AddFivePointCalc_Int()
    {
      Player inputWord = new Player("adcyk");
      inputWord.ScoreCalc();
      Assert.AreEqual(15, inputWord.UserPoints);
    }
    [TestMethod]
    public void ScoreCalc_AddEightPointCalc_Int()
    {
      Player inputWord = new Player("adcykx");
      inputWord.ScoreCalc();
      Assert.AreEqual(23, inputWord.UserPoints);
    }
    [TestMethod]
    public void ScoreCalc_AddTenPointCalc_Int()
    {
      Player inputWord = new Player("adcykxqz");
      inputWord.ScoreCalc();
      Assert.AreEqual(43, inputWord.UserPoints);
    }
  }
}
