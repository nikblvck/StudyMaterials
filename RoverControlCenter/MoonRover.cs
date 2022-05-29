namespace RoverControlCenter
{
  class MoonRover : Rover
  {
    public MoonRover(string alias, int yearLanded) : base (alias, yearLanded)
    {}
    public override string Explore()
    {
      return "Moon Rover is exploring the surface!";
    }
    public override string Collect()
    {
      return "Moon Rover is collecting rocks!";
    }
  }
}
