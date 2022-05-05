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
    char[] charArray = {'H', 'e', 'l', 'l', 'o'};
    Assert.AreEqual(true, charArray.SequenceEqual(inputWord.UserWordArray));
    }
  }
}
