//Concatenating Strings

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "My name is Nik and I really enjoy creating things.";

      string middle = "I'd have to say, my favorite creation is my daughter - D!";

      string end = "She is the absolute coolest person I have ever had the pleasure of meeting in this life or any other";
      // Concatenate the string and the variables
    string story = beginning + middle + end;
      // Print the story to the console
    Console.WriteLine(story);

    }
  }
}

