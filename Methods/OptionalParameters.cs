//Using optional parameters with a method
//You can use optional parameters with a method by using the following syntax:

using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(4);
      VisitPlanets(6);
      VisitPlanets(1);
      VisitPlanets();
    }
    static void VisitPlanets(int numberOfPlanets = 0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets named {name}...");
    }
  }
}
