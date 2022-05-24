//Choose Your Own Adventure - String Interpolation and Switch Statements

using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
    static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */
      // Start by asking for the user's name:
      Console.Write("What is your name? ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write("Type YES or NO: ");
      //Store the user's answer in a variable called noiseChoice:
      string noiseChoice = Console.ReadLine();
      //Change user's answer string to uppercase:
      noiseChoice = noiseChoice.ToUpper();
      //If the user's answer is NO, then:
      if (noiseChoice == "NO")
      {
        //Print the following:
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END.");
      }
      else
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      }

      //Ask the user for a decision and store their answer in a variable called doorChoice:
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      //Change user's answer string to uppercase:
      doorChoice = doorChoice.ToUpper();

      //If the user's answer is KNOCK, then:
      if (doorChoice == "KNOCK")
      {
        //Print the following:
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
        Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
      }
      // If the user's answer is OPEN
      else if (doorChoice == "OPEN")
      {
        //Print the following:
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("Enter a number: ");
        //Store the user's answer in a variable called keyChoice:
        string keyChoice = Console.ReadLine();
        //Change user's answer string to uppercase:
        keyChoice = keyChoice.ToUpper();
        //Switch case for possible answers:
        switch (keyChoice)
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky Choice!");
            Console.WriteLine("The door opens and NOTHING is there.");
            Console.WriteLine("Strange...");
            Console.WriteLine("THE END");
          break;
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open.");
            Console.WriteLine("THE END");
          break;
          case "3":
            Console.WriteLine("You choose the third key. The door doesn't open.");`
            Console.WriteLine("THE END");
        }
      }
      //Captuer user's answer to the riddle:
      string riddleAnswer = Console.ReadLine();
      //Change user's answer string to uppercase:
      riddleAnswer = riddleAnswer.ToUpper();

      //If the user's answer is correct, then:
      if (riddleAnswer == "NOTHING")
      {
        //Print the following:
        Console.WriteLine("The door opens and NOTHING is there.");
        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
        Console.WriteLine("THE END.");
      }
      else
      {
        Console.WriteLine("You answered incorrectly. The door didn't open.");
        Console.WriteLine("THE END.");
      }

    }
  }
}
