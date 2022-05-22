//Calculating age in dog years

using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program!
      Here's what you learned:

      DATA TYPES: int, double
      ARITHMETIC OPERATORS: +, -, *, /
      INCREMENT/DECREMENT: ++, --
      MODULO: %
      BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

      Good luck! */
      int age = 31;
      int doobiesAge = 12;
      int dogYears = 7;
      int myAgeDogYears = age*dogYears;
      int doobieAgeDogYears = doobiesAge*dogYears;
      Console.WriteLine(myAgeDogYears);
      Console.WriteLine(doobieAgeDogYears);

    }
  }
}
