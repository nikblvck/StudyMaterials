//Using various methods, find and calculate the cost of various landmarks

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    static void Main(string[] args)
    {
      //Finding the area of Teotihuacan
      double area = Rectangle(2500, 1500) + Circle(375) + Triangle(750, 500);
      Console.WriteLine($"The area of Teotihuacan is {area}");
      //Flooring material cost
      double flooring = 180;
      //Cost of building Teotihuacan - rounds value to two decimal places
      double cost = Math.Round(area * flooring, 2);
      Console.WriteLine($"The cost of building Teotihuacan is {cost}");

    }
    static double Rectangle(double length, double width)
    {
      return length * width;
    }
    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }
    static double Triangle (double baseLength, double height)
    {
      return (baseLength * height) / 2;
    }
    static double CalculateTotalCost(double area, double flooring)
    {
      return Math.Round(area * flooring, 2);
    }
  }
}
