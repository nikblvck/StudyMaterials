//Method Overloading - useful if you want the same method to have different behavior based on input
using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }

    static void NamePets(string petName1, string petName2)
    {
      Console.WriteLine($"Your pets {petName1} and {petName2} will be joining your voyage across space!");
    }

    static void NamePets(string petName1, string petName2, string petName3)
    {
      Console.WriteLine($"Your pets {petName1}, {petName2}, and {petName3} will be joining your voyage across space!");
    }

    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}
