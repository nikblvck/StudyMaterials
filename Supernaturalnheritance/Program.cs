using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm storm1 = new Storm("wind", false, "Zul'rajas");

      Console.WriteLine(storm1.Announce());
      Pupil mezi = new Pupil("Mezil-kree");
      Storm windStorm = mezi.CastWindStorm();
      Console.WriteLine(windStorm.Announce());
      Mage gul = new Mage("Gul'dan");
      Storm rainStorm = gul.CastRainStorm();
      Console.WriteLine(rainStorm.Announce());
      Archmage neil = new Archmage("Neilas Aran");
      Storm heavyRain = neil.CastRainStorm();
      Storm lightning = neil.CastLightningStorm();
      Console.WriteLine(heavyRain.Announce());
      Console.WriteLine(lightning.Announce());

      Storm[] storms = new Storm[10];
      int stormIndex = 0;



    }
  }
}
