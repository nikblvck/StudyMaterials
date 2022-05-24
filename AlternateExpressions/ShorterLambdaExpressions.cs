//Shorter syntax (shortcuts) for lambda expressions
// Remove Parameter Type:
// Array.Exists(array, (s) => s == "meteorite");
// Remove Parentheses:
// Array.Exists(spaceRocks, s => s == "meteorite");
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};

      bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");

      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      }
    }
  }
}
