using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Project.Models
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void GetScore_StringToInt_ExpectedInteger()
    {
      Scrabble ChecksIfScoreIsInt = new Scrabble("Hello");
      int result = ChecksIfScoreIsInt.GetScore("Hello");
      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void Scrabble_ValidInput_String()
    {
      Scrabble CheckIfInputIsString = new Scrabble("Hello World");
      Assert.AreEqual(typeof(Scrabble), CheckIfInputIsString.GetType());
    }
  }
}