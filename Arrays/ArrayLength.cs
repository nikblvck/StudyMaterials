//Finding the length of an array

using System;

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "Despacito", "Los Angeles" };

      if (summerStrut.Length == 8)
      {
        Console.WriteLine("summerStrut Playlist is ready to go!");
      }
      else if (summerStrut.Length > 8)
      {
        Console.WriteLine("summerStrut Playlist is too long! You've got too many songs!");
      }
      else
      {
        Console.WriteLine("Add more songs to the playlist!");
      }

    }
  }
}
