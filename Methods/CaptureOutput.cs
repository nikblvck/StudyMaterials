//Capture output from a method

using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";

      int indexOfSpace = designer.IndexOf(" ");

      string secondName = designer.Substring(indexOfSpace);

      Console.WriteLine(secondName);
    }
  }
}
