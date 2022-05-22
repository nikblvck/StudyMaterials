//Interpolating Strings
using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning} there was a little boy who liked to eat cheese. {middle} and ate his cheese wheel happily as his friends played below. {end}";

      // Print the story to the console
      Console.WriteLine(story);
    }
  }
}

