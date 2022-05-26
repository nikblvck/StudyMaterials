using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = { "I like olives", "I love macaroni & cheese", "I like to watch baseball", "I enjoy creating things", "I do not like animals of any kind", "I do not like Disney movies" };
      bool[] answers = {false, true, false, true, false, false};
      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Error: questions and answers arrays are not the same length");
      }

      int askingIndex = 0;
      foreach (string question in questions)
      {
      //Define empty variables before asking questions
      string input;
      bool isBool = true;
      bool inputBool;
      //Ask question
      Console.WriteLine(question);
      Console.Write("True or False? ");
      //Get input
      input = Console.ReadLine();
      isBool = Boolean.TryParse(input, out inputBool);

      //Create empty while loop to check if input is a boolean
      while(isBool == false)
      {
        Console.WriteLine("Please respond with 'true' or 'fasle'.");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
      }

      }

    }
  }
}
