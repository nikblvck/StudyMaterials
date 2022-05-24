//Game creating monsters with various pieces

using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1 = TranslateToNumber("ghost");
      int num2 = T`ranslateToNumber("bug");
      int num3 = TranslateToNumber("monster");

      SwitchCase(num1, num2, num3);
      RandomMode();
    }
    static void BuildACreature(string head, string body, string feet)
    {
      switch (head)
      {
        case "monster":
          MonsterHead();
          break;
        case "ghost":
          GhostHead();
          break;
        case "bug":
          BugHead();
          break;
      }

      switch (body)
      {
        case "monster":
          MonsterBody();
          break;
        case "ghost":
          GhostBody();
          break;
        case "bug":
          BugBody();
          break;
      }

      switch (feet)
      {
        case "monster":
          MonsterFeet();
          break;
        case "ghost":
          GhostFeet();
          break;
        case "bug":
          BugFeet();
          break;
      }
    }
    static void RandomMode()
    {
      Random randomNumber = new Random();
      int randomNumber1 = randomNumber.Next(1, 4);
      int randomNumber2 = randomNumber.Next(1, 4);
      int randomNumber3 = randomNumber.Next(1, 4);

      SwitchCase(randomNumber1, randomNumber2, randomNumber3);
    }
    static int TranslateToNumber(string creature)
    {
      switch(creature)
    {
      case "monster":
        return 1;
      case "ghost":
        return 2;
      case "bug":
        return 3;
      default:
        return 1;
    }
    }

    static void SwitchCase(int head, int body, int feet)
    {
      switch(head)
      {
        case 1:
          MonsterHead();
          break;
        case 2:
          GhostHead();
          break;
        case 3:
          BugHead();
          break;
      }

      switch(body)
      {
        case 1:
          MonsterBody();
          break;
        case 2:
          GhostBody();
          break;
        case 3:
          BugBody();
          break;
      }

      switch(feet)
      {
        case 1:
          MonsterFeet();
          break;
        case 2:
          GhostFeet();
          break;
        case 3:
          BugFeet();
          break;
      }
    }
    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
