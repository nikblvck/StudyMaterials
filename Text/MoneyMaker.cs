//Money Maker


using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.Write("What amount would you like to convert: ");
      string amount = Console.ReadLine();
      double amountNum = Convert.ToDouble(amount);
      Console.Write($"{amount} cents is equal to...");


      int silverCoin = 10;
      int goldCoin = 5;

      double goldCoins = Math.Floor(amountNum/goldCoin);
      double remainder = amountNum % goldCoin;
      double silverCoins = Math.Floor(goldCoins/silverCoin);
      remainder = remainder % silverCoins;


      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remainder}");

    }
  }
}
