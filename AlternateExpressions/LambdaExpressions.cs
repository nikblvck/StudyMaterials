//great for situations when you need to pass a method as an argument

//SYNTAX:
//  Array.Find(array, method);
//  Array.FindIndex(array, method);
//  Array.FindAll(array, method);
//  Array.Exists(array, method);
//  Array.TrueForAll(array, method);
//  Array.ForEach(array, method);
//  Array.Sort(array, method);
//  Array.Sort(array, method, comparer);
//  Array.BinarySearch(array, value);
//  Array.BinarySearch(array, value, comparer);
//  Array.BinarySearch(array, index, length, value);
//  Array.BinarySearch(array, index, length, value, comparer);
//  Array.AsReadOnly(array);
//  Array.Copy(array, destinationArray);
//  Array.Copy(array, destinationArray, arrayIndex, length);
//  Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
//  Array.Clear(array, index, length);
//  Array.Reverse(array);
//  Array.Reverse(array, index, length);
//  Array.Sort(array);
//  Array.Sort(array, comparer);
//  Array.Sort(array, index, length);
//  Array.Sort(array, index, length, comparer);
//  Array.Sort(array, comparer);

using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};

      bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      }
    }

  }
}
