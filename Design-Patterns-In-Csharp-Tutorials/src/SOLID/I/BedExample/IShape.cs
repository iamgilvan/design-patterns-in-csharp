using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.I.BadExample
{
    public interface IShape
    {
        double Area();
        double Volume(); // problem: 2D shapes don't have volume
    }
}