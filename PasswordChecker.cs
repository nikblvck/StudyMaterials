//Password Checker - Checks password validity and returns a message

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8 ;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits =  "1234567890";
      string specialChars = "!@#$%^&*()";

      Console.Write("Enter a password: ");
      string password = Console.ReadLine();

      int score = 0;
      if (password.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }

      Console.WriteLine(score);

      switch(score)
      {
        case 5:
          Console.WriteLine("Extremely Strong Password");
        break;
        case 4:
          Console.WriteLine("Extremely Strong Password");
        break;
        case 3:
          Console.WriteLine("Strong Password");
        break;
        case 2:
          Console.WriteLine("Medium Password");
        break;
         case 1:
          Console.WriteLine("Medium Password");
        break;
        default:
          Console.WriteLine("Please create a new password");
        break;


      }
    }
  }
}

