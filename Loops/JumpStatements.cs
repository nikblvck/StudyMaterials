//Using statements to bypass or break out of a loop.

using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int ringCounter = 0;
      do
      {
        Console.WriteLine("BLARRRRR");
        ringCounter++;
        if (ringCounter == 3) {
          break;
        }

      } while(!buttonClick);
    }
  }
}

