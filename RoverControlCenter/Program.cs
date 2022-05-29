using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957);
//Store rovers in array
      Rover[] rovers = { lunokhod, apollo, sojourner };


//Store probes in array
      Object[] probes = { lunokhod, apollo, sojourner, sputnik };

      foreach (Object p in probes)
      {
        Console.WriteLine($"Tracking a {p.GetType()}...");
      }

      IDirectable[] probesArr = { lunokhod, apollo, sojourner, sputnik };

 DirectAll(probesArr);

    }


    public static void DirectAll(IDirectable[] roverArr)
    {
      foreach (IDirectable r in roverArr)
      {
        Console.WriteLine(r.GetInfo());
        Console.WriteLine(r.Explore());
        Console.WriteLine(r.Collect());
      }

    }
  }
}
