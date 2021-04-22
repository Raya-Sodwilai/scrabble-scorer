using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Project.Models
{
  public class Scrabble
  { 
    public static Dictionary<char, int> letterScores = new Dictionary<char, int>() { 
      {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, 
		  {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
		  {'D', 2}, {'G', 2},
		  {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
		  {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
		  {'K', 5},
		  {'J', 8}, {'X', 8},
		  {'Q',10}, {'Z',10},
    }; 

    public string Input { get; set; }

    public Scrabble(string input)
    {
      Input = input;
    }
    public int GetScore(string input)
    {
      int totalScores = 0;
      string inputUpper = input.ToUpper();
      for (int i = 0; i < inputUpper.Length; i++)
      {
        if(letterScores.ContainsKey(inputUpper[i]))
        {
          totalScores += letterScores[inputUpper[i]];
          Console.BackgroundColor = ConsoleColor.Blue;
        }
      }
      Console.WriteLine("Your Score:" + "" + totalScores);
      return totalScores;
    }
  }
}