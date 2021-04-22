using System.Collections.Generic;
using System.Linq;
using System;

namespace Project.Models
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a Word:");
      string input = Console.ReadLine();
      Scrabble console = new Scrabble(input);
      console.GetScore(input);
    }
  }
}