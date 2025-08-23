using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.I.BetterExample
{
    public class Circle: IShape2D
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}