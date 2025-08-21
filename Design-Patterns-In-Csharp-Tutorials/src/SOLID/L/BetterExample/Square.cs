using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.L.BetterExample
{
    public class Square : Shape
  {
    private double sideLength;

    public double SideLength
    {
      get => sideLength;
      set
      {
        sideLength = value;
      }
    }

    public override double Area => sideLength * sideLength;
  }
}