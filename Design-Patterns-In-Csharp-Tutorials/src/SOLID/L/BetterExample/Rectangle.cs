using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.L.BetterExample
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => Width * Height;
    }
}