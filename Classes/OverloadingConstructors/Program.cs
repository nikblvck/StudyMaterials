using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      Forest f1 = new Forest("Rendlesham");
      f.Trees = 0;
      Console.WriteLine(f1.Biome);
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}
