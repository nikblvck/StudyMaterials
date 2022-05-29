namespace RoverControlCenter{
  class MarsRover : Rover
  {
    public MarsRover(string alias, int yearLanded) : base(alias, yearLanded)
    {}

    public override string Explore()
      {
        return "Mars Rover is exploring the surface!";
      }
    public override string Collect()
    {
     return "Mars Rover is collecting rocks!";
    }
  }
}
